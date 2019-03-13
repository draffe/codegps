var url = "http://localhost:53895/api/";
var Post = function (arg,urldestino, respuestacorrecta, problema) {
    $.ajax({
        url: url + urldestino,
        type: 'POST',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        data: JSON.stringify(arg),
        success: function (data) {
            respuestacorrecta(data);
        },
        error: function (error) {
            console.log(error)
            problema(error)
        },
    });
}

var PostHtml = function (arg, urldestino, respuestacorrecta, problema) {
    $.ajax({
        url: url + urldestino,
        type: 'POST',
        contentType: 'application/json; charset=utf-8',
        dataType: "html",
        data: JSON.stringify(arg),
        success: function (data) {
            respuestacorrecta(data);
        },
        error: function (error) {
            console.log(error)
            problema(error)
        },
    });
}
var Get = function (urldestino, respuestacorrecta, problema) {
    $.ajax({
        url: url + urldestino,
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            respuestacorrecta(data);
        },
        error: function (error) {
            console.log(error)
            problema(error)
        },
    });
}

var GetHtml = function (urldestino, respuestacorrecta, problema) {
    $.ajax({
        url: url + urldestino,
        type: 'GET',
        dataType: "html",
        success: function (data) {
            respuestacorrecta(data);
        },
        error: function (error) {
            console.log(error)
            problema(error)
        },
    });
}

 