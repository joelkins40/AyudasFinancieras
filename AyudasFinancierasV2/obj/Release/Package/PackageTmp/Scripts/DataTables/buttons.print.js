(function( factory ){
	if ( typeof define === 'function' && define.amd ) {
		define( ['jquery', 'datatables.net', 'datatables.net-buttons'], function ( $ ) {
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
			if ( ! $.fn.dataTable.Buttons ) {
				require('datatables.net-buttons')(root, $);
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
var _link = document.createElement( 'a' );
var _styleToAbs = function( el ) {
	var url;
	var clone = $(el).clone()[0];
	var linkHost;
	if ( clone.nodeName.toLowerCase() === 'link' ) {
		clone.href = _relToAbs( clone.href );
	}
	return clone.outerHTML;
};
var _relToAbs = function( href ) {
	_link.href = href;
	var linkHost = _link.host;
	if ( linkHost.indexOf('/') === -1 && _link.pathname.indexOf('/') !== 0) {
		linkHost += '/';
	}
	return _link.protocol+"//"+linkHost+_link.pathname+_link.search;
};
DataTable.ext.buttons.print = {
	className: 'buttons-print',
	text: function ( dt ) {
		return dt.i18n( 'buttons.print', 'Print' );
	},
	action: function ( e, dt, button, config ) {
		var data = dt.buttons.exportData( config.exportOptions );
		var addRow = function ( d, tag ) {
			var str = '<tr>';
			for ( var i=0, ien=d.length ; i<ien ; i++ ) {
				str += '<'+tag+'>'+d[i]+'</'+tag+'>';
			}
			return str + '</tr>';
		};
		var html = '<table class="'+dt.table().node().className+'">';
		if ( config.header ) {
			html += '<thead>'+ addRow( data.header, 'th' ) +'</thead>';
		}
		html += '<tbody>';
		for ( var i=0, ien=data.body.length ; i<ien ; i++ ) {
			html += addRow( data.body[i], 'td' );
		}
		html += '</tbody>';
		if ( config.footer && data.footer ) {
			html += '<tfoot>'+ addRow( data.footer, 'th' ) +'</tfoot>';
		}
		var win = window.open( '', '' );
		var title = config.title;
		if ( typeof title === 'function' ) {
			title = title();
		}
		if ( title.indexOf( '*' ) !== -1 ) {
			title= title.replace( '*', $('title').text() );
		}
		win.document.close();
		var head = '<title>'+title+'</title>';
		$('style, link').each( function () {
			head += _styleToAbs( this );
		} );
		try {
			win.document.head.innerHTML = head; // Work around for Edge
		}
		catch (e) {
			$(win.document.head).html( head ); // Old IE
		}
		win.document.body.innerHTML =
			'<h1>'+title+'</h1>'+
			'<div>'+
				(typeof config.message === 'function' ?
					config.message( dt, button, config ) :
					config.message
				)+
			'</div>'+
			html;
		$(win.document.body).addClass('dt-print-view');
		$('img', win.document.body).each( function ( i, img ) {
			img.setAttribute( 'src', _relToAbs( img.getAttribute('src') ) );
		} );
		if ( config.customize ) {
			config.customize( win );
		}
		setTimeout( function () {
			if ( config.autoPrint ) {
				win.print(); // blocking - so close will not
				win.close(); // execute until this is done
			}
		}, 250 );
	},
	title: '*',
	message: '',
	exportOptions: {},
	header: true,
	footer: false,
	autoPrint: true,
	customize: null
};
return DataTable.Buttons;
}));
