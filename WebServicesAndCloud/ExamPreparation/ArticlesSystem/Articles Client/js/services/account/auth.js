	

    'use strict';
     
    app.factory('auth', function($http, $q, identity, authorization, UsersResource, baseUrl) {
        var usersApi = baseUrl + '/api/users'
     
        return {
            signup: function(user) {
                var deferred = $q.defer();
                $http.post(usersApi + '/Register', {
                        Email: user.email,
                        Password: user.password,
                        ConfirmPassword: user.password
                    },
                    {
                        transformRequest: function (obj) {
                            var str = [];
                            for (var p in obj)
                                str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                            return str.join("&");
                        },
                        headers: {
                            'Content-Type': 'application/x-www-form-urlencoded'
                        }
                    })
                    .success(function (data, status, headers, config) {
                        deferred.resolve(data);
                    })
     
                return deferred.promise;
            },
            login: function(user){
                var deferred = $q.defer();
                user['grant_type'] = 'password';
                $http.post(usersApi + '/login', 'username=' + user.username + '&password=' + user.password + '&grant_type=password', { headers: {'Content-Type': 'application/x-www-form-urlencoded'} }).success(function(response) {
                    if (response["access_token"]) {
                        identity.currentUser = response;
                        deferred.resolve(true);
                    }
                    else {
                        deferred.resolve(false);
                    }
                });
     
                return deferred.promise;
            },
            logout: function() {
                var deferred = $q.defer();
                $http.put(usersApi + '/Logout')
                    .success(function (data, status, headers, config) {
                        identity.currentUser = undefined;
                        deferred.resolve(data);
                    })
     
                return deferred.promise;
            },
            isAuthenticated: function() {
                if (identity.isAuthenticated()) {
                    return true;
                }
                else {
                    return $q.reject('not authorized');
                }
            },
            isAuthorizedForRole: function(role) {
                if (identity.isAuthorizedForRole(role)) {
                    return true;
                }
                else {
                    return $q.reject('not authorized');
                }
            }
        }
    })

