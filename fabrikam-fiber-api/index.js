var rest = require('rest');
 
rest('http://localhost:11709/api').then(function(response) {
    console.log('response: ', response);
});