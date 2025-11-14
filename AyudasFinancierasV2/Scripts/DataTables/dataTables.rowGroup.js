(function( factory ){
	if ( typeof define === 'function' && define.amd ) {
		define( ['jquery', 'datatables.net'], function ( $ ) {
			return factory( $, window, document );
		} );
	}
	else if ( typeof exports === 'object' ) {
		module.exports = function (root, $) {
			if ( ! root ) {
				root = window;
			}
			if ( ! $ || ! $.fn.dataTable ) {
				$ = require('datatables.net')(root, $).$;
			}
			return factory( $, root, root.document );
		};
	}
	else {
		factory( jQuery, window, document );
	}
}(function( $, window, document, undefined ) {
'use strict';
var DataTable = $.fn.dataTable;
var RowGroup = function ( dt, opts ) {
	if ( ! DataTable.versionCheck || ! DataTable.versionCheck( '1.10.8' ) ) {
		throw 'RowGroup requires DataTables 1.10.8 or newer';
	}
	this.c = $.extend( true, {},
		DataTable.defaults.rowGroup,
		RowGroup.defaults,
		opts
	);
	this.s = {
		dt: new DataTable.Api( dt ),
		dataFn: DataTable.ext.oApi._fnGetObjectDataFn( this.c.dataSrc ),
	};
	this.dom = {
	};
	var settings = this.s.dt.settings()[0];
	var existing = settings.rowGroup;
	if ( existing ) {
		return existing;
	}
	settings.rowGroup = this;
	this._constructor();
};
$.extend( RowGroup.prototype, {
	dataSrc: function ( val )
	{
		if ( val === undefined ) {
			return this.c.dataSrc;
		}
		var dt = this.s.dt;
		this.c.dataSrc = val;
		this.s.dataFn = DataTable.ext.oApi._fnGetObjectDataFn( this.c.dataSrc );
		$(dt.table().node()).triggerHandler( 'rowgroup-datasrc.dt', [ dt, val ] );
		return this;
	},
	disable: function ()
	{
		this.c.enable = false;
		return this;
	},
	enable: function ( flag )
	{
		if ( flag === false ) {
			return this.disable();
		}
		this.c.enable = true;
		return this;
	},
	_constructor: function ()
	{
		var that = this;
		var dt = this.s.dt;
		dt.on( 'draw.dtrg', function () {
			if ( that.c.enable ) {
				that._draw();
			}
		} );
		dt.on( 'column-visibility.dtrg', function () {
			that._adjustColspan();
		} );
		dt.on( 'destroy', function () {
			dt.off( '.dtrg' );
		} );
	},
	_adjustColspan: function ()
	{
		$( 'tr.'+this.c.className, this.s.dt.table().body() )
			.attr( 'colspan', this._colspan() );
	},
	_colspan: function ()
	{
		return $( this.s.dt.columns().header() ).filter(':visible').length;
	},
	_draw: function ()
	{
		var that = this;
		var dt = this.s.dt;
		var rows = dt.rows( { page: 'current' } );
		var groupedRows = [];
		var last, display;
		rows.every( function () {
			var d = this.data();
			var group = that.s.dataFn( d );
			if ( last === undefined || group !== last ) {
				groupedRows.push( [] );
				last = group;
			}
			groupedRows[ groupedRows.length - 1 ].push( this.index() );
		} );
		for ( var i=0, ien=groupedRows.length ; i<ien ; i++ ) {
			var group = groupedRows[i];
			var firstRow = dt.row(group[0]);
			var groupName = this.s.dataFn( firstRow.data() );
			if ( this.c.startRender ) {
				display = this.c.startRender.call( this, dt.rows(group), groupName );
				this
					._rowWrap( display, this.c.startClassName )
					.insertBefore( firstRow.node() );
			}
			if ( this.c.endRender ) {
				display = this.c.endRender.call( this, dt.rows(group), groupName );
				this
					._rowWrap( display, this.c.endClassName )
					.insertAfter( dt.row( group[ group.length-1 ] ).node() );
			}
		}
	},
	_rowWrap: function ( display, className )
	{
		var row;
		if ( typeof display === 'object' && display.nodeName && display.nodeName.toLowerCase() === 'tr') {
			row = $(display);
		}
		else if (display instanceof $ && display.length && display[0].nodeName.toLowerCase() === 'tr') {
			row = display;
		}
		else {
			row = $('<tr/>')
				.append(
					$('<td/>')
						.attr( 'colspan', this._colspan() )
						.append( display  )
				);
		}
		return row
			.addClass( this.c.className )
			.addClass( className );
	}
} );
RowGroup.defaults = {
	className: 'group',
	dataSrc: 0,
	enable: true,
	endClassName: 'group-end',
	endRender: null,
	startClassName: 'group-start',
	startRender: function ( rows, group ) {
		return group;
	}
};
RowGroup.version = "1.0.0";
$.fn.dataTable.RowGroup = RowGroup;
$.fn.DataTable.RowGroup = RowGroup;
DataTable.Api.register( 'rowGroup()', function () {
	return this;
} );
DataTable.Api.register( 'rowGroup().disable()', function () {
	return this.iterator( 'table', function (ctx) {
		if ( ctx.rowGroup ) {
			ctx.rowGroup.enable( false );
		}
	} );
} );
DataTable.Api.register( 'rowGroup().enable()', function ( opts ) {
	return this.iterator( 'table', function (ctx) {
		if ( ctx.rowGroup ) {
			ctx.rowGroup.enable( opts === undefined ? true : opts );
		}
	} );
} );
DataTable.Api.register( 'rowGroup().dataSrc()', function ( val ) {
	if ( val === undefined ) {
		return this.context[0].rowGroup.dataSrc();
	}
	return this.iterator( 'table', function (ctx) {
		if ( ctx.rowGroup ) {
			ctx.rowGroup.dataSrc( val );
		}
	} );
} );
$(document).on( 'preInit.dt.dtrg', function (e, settings, json) {
	if ( e.namespace !== 'dt' ) {
		return;
	}
	var init = settings.oInit.rowGroup;
	var defaults = DataTable.defaults.rowGroup;
	if ( init || defaults ) {
		var opts = $.extend( {}, defaults, init );
		if ( init !== false ) {
			new RowGroup( settings, opts  );
		}
	}
} );
return RowGroup;
}));
