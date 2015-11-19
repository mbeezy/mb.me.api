(function () {

    "use strict";

    angular
        .module("common.services")
        .factory("surfSpotResource", ["$resource", "appSettings", surfSpotResource])

    function surfSpotResource($resource, appSettings) {
        return $resource(appSettings.serverPath + "/api/surfspots/:id", null,
                {
                    'update': { method: 'PUT' }
                });
    }

}());