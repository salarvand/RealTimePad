$(document).ready(function () {

    "use strict";

    window.AppNs = {};

    /**********************************************************

            BEGIN: GLOBAL
            
    **********************************************************/

    (function (ns) {

    }(window.AppNs));

    /**********************************************************

            BEGIN: HELPER METHOD
            
    **********************************************************/

    (function (ns) {
        var viewModelHelper = function () {

            var self = this;
            self.apiGet = function (uri, data, success, failure, always) {

                $.get(AppNs.rootPath + uri, data)
                    .done(success)
                    .fail(function (result) {
                        if (failure == null) {
                            if (result.status != 400)
                                console.log(result.status + ':' + result.statusText + ' - ' + result.responseText);
                            else
                                console.log(JSON.parse(result.responseText));
                        }
                        else
                            failure(result);
                    })
                    .always(function () {
                        if (always != null)
                            always();
                    });
            };
            self.apiPost = function (uri, data, success, failure, always) {

                $.post(AppNs.rootPath + uri, data)
                    .done(success)
                    .fail(function (result) {
                        if (failure == null) {
                            if (result.status != 400)
                                console.log(result.status + ':' + result.statusText + ' - ' + result.responseText);
                            else
                                console.log(JSON.parse(result.responseText));
                        }
                        else
                            failure(result);
                    })
                    .always(function () {
                        if (always != null)
                            always();
                    });
            };
        }
        ns.viewModelHelper = viewModelHelper;
    }(window.AppNs));

    /**********************************************************
    
                BEGIN: KNOCKOUT VIEWMODEL
                
    **********************************************************/

    (function (ns) {
        ns.rootPath = window.location.href;



        var padModel = {
            messageContent:  ko.observable(),

            saveMessage:function(){
                var self = this;
                console.log(self.messageContent());
            }
        };

        var viewModel = {
            pad : padModel
        };

        ko.applyBindings(viewModel);
        ns.viewModel = viewModel;

    })(window.AppNs);
});
