$(document).ready(function () {
    getUserList();
});

function getUserList() {
    var settings = {
        "url": "http://localhost:5078/api/UserAPI/getUserData",
        "method": "POST",
        "timeout": 0,
    };

    $.ajax(settings).done(function (response) {
        if (response != null) {
            //$("#tmplData").tmpl(response).appendTo("#tmplBody");
           // jQuery("#tmplData").tmpl(response).appendTo("#tmplBody");
            //var tmplBody = document.getElementById("tmplBody");


            var tmplData = document.getElementById('tmplData');
            var tmplBody = document.getElementById('tmplBody');
            tmplBody.innerHTML = '';
            response.forEach(function (item) {
                var template = document.createElement('tr');
                template.innerHTML = '<td>' + item.userName + '</td>'
                    + '<td>' + item.mobileNo + '</td > '
                    + '<td>' + item.address + '</td > '
                    ;
                tmplBody.appendChild(template);
            });
        }
    });
}