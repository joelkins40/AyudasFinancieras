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
$.extend( true, DataTable.defaults, {
	dom:
		"<'row uk-grid'<'uk-width-1-2'l><'uk-width-1-2'f>>" +
		"<'row uk-grid dt-merge-grid'<'uk-width-1-1'tr>>" +
		"<'row uk-grid dt-merge-grid'<'uk-width-2-5'i><'uk-width-3-5'p>>",
	renderer: 'uikit'
} );
$.extend( DataTable.ext.classes, {
	sWrapper:      "dataTables_wrapper uk-form dt-uikit",
	sFilterInput:  "uk-form-small",
	sLengthSelect: "uk-form-small",
	sProcessing:   "dataTables_processing uk-panel"
} );
DataTable.ext.renderer.pageButton.uikit = function ( settings, host, idx, buttons, page, pages ) {
	var api     = new DataTable.Api( settings );
	var classes = settings.oClasses;
	var lang    = settings.oLanguage.oPaginate;
	var aria = settings.oLanguage.oAria.paginate || {};
	var btnDisplay, btnClass, counter=0;
	var attach = function( container, buttons ) {
		var i, ien, node, button;
		var clickHandler = function ( e ) {
			e.preventDefault();
			if ( !$(e.currentTarget).hasClass('disabled') && api.page() != e.data.action ) {
				api.page( e.data.action ).draw( 'page' );
			}
		};
		for ( i=0, ien=buttons.length ; i<ien ; i++ ) {
			button = buttons[i];
			if ( $.isArray( button ) ) {
				attach( container, button );
			}
			else {
				btnDisplay = '';
				btnClass = '';
				switch ( button ) {
					case 'ellipsis':
						btnDisplay = '<i class="uk-icon-ellipsis-h"></i>';
						btnClass = 'uk-disabled disabled';
						break;
					case 'first':
						btnDisplay = '<i class="uk-icon-angle-double-left"></i> ' + lang.sFirst;
						btnClass = (page > 0 ?
							'' : ' uk-disabled disabled');
						break;
					case 'previous':
						btnDisplay = '<i class="uk-icon-angle-left"></i> ' + lang.sPrevious;
						btnClass = (page > 0 ?
							'' : 'uk-disabled disabled');
						break;
					case 'next':
						btnDisplay = lang.sNext + ' <i class="uk-icon-angle-right"></i>';
						btnClass = (page < pages-1 ?
							'' : 'uk-disabled disabled');
						break;
					case 'last':
						btnDisplay = lang.sLast + ' <i class="uk-icon-angle-double-right"></i>';
						btnClass = (page < pages-1 ?
							'' : ' uk-disabled disabled');
						break;
					default:
						btnDisplay = button + 1;
						btnClass = page === button ?
							'uk-active' : '';
						break;
				}
				if ( btnDisplay ) {
					node = $('<li>', {
							'class': classes.sPageButton+' '+btnClass,
							'id': idx === 0 && typeof button === 'string' ?
								settings.sTableId +'_'+ button :
								null
						} )
						.append( $(( -1 != btnClass.indexOf('disabled') || -1 != btnClass.indexOf('active') ) ? '<span>' : '<a>', {
								'href': '#',
								'aria-controls': settings.sTableId,
								'aria-label': aria[ button ],
								'data-dt-idx': counter,
								'tabindex': settings.iTabIndex
							} )
							.html( btnDisplay )
						)
						.appendTo( container );
					settings.oApi._fnBindAction(
						node, {action: button}, clickHandler
					);
					counter++;
				}
			}
		}
	};
	var activeEl;
	try {
		activeEl = $(host).find(document.activeElement).data('dt-idx');
	}
	catch (e) {}
	attach(
		$(host).empty().html('<ul class="uk-pagination uk-pagination-right"/>').children('ul'),
		buttons
	);
	if ( activeEl ) {
		$(host).find( '[data-dt-idx='+activeEl+']' ).focus();
	}
};
return DataTable;
}));