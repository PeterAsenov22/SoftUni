<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Bug Tracker</title>
    <style>
        #wrapper {
            width: 800px;
            border: 1px solid black;
        }
        #titlebar {
            background-color: beige;
            font-size: 2em;
            padding: 0.5em;
        }
        .report {
            margin: 1em;
            border: 1px solid black;
            width: 400px;
        }
        .report .title {
            background-color: cornflowerblue;
            color: white;
            padding: 0.25em;
            position: relative;
        }
        .report .body p {
            margin: 0.5em;
        }
        .report .title .status {
            display: inline-block;
            right: 0px;
            position: absolute;
            margin-right: 0.5em;
        }
    </style>
    <script src="https://code.jquery.com/jquery-3.1.1.min.js"
            integrity="sha256-hVVnYaiADRTO2PzUGmuLJr8BLUSjGIZsDYGmIJLv2b8=" crossorigin="anonymous"></script>
    <script src="08. Bug Tracker.js"></script>
    <script>
        $(document).ready(function () {
            let manager = generateBugManager();
            manager.output('#content');
            manager.report('kiwi', 'judge rip', true, 5);
            manager.report('lemon', 'judge rip ^ 2', false, 18);
            manager.report('apple', 'judge rip?', true, 155);
            manager.remove(1);
            manager.sort('ID');
        });

        function generateBugManager() {
            let storage = [];
            let initialId = 0;

            let result = {
                report: function (author, description, reproducible, severity) {
                    storage.push({
                        ID: initialId,
                        author: author,
                        description: description,
                        reproducible: reproducible,
                        severity: severity,
                        status: 'Open'
                    });
                    initialId++;
                    print (result.selector)
                },
                setStatus: function (id, status) {
                    for (let obj of storage){
                        if (obj.ID == id){
                            obj.status = status
                        }
                    }
                    print (result.selector)
                },
                remove: function (id) {
                    let targetIndex = 0;
                    for (let i = 0;i < storage.length;i++){
                        if (storage[i].ID == id){
                            targetIndex = i;
                            break
                        }
                    }
                    storage.splice(targetIndex, 1);
                    print (result.selector)
                },
                sort: function (method) {
                    if (method == 'author'){
                        storage.sort((a,b) => {
                            return a[method].localeCompare(b[method])
                        })
                    } else {
                        storage.sort((a,b) => {
                            return a[method] - b[method]
                        })
                    }
                    print (result.selector)
                },
                output: (selector) => {
                    result.selector = selector
                },
                selector:'',
            };

            function print (selector){
                let container = $(selector);
                container.empty();
                for (let i=0;i<storage.length;i++){
                    let report = $('<div>');
                    report.attr('id', `report_${storage[i].ID}`);
                    report.addClass('report');
                    let descrDiv = $('<div class="body">');
                    let descr = $('<p>').text(`${storage[i].description}`);
                    descrDiv.append(descr);
                    let titleDiv = $(`<div class="title">`);
                    let spanAuthor = $(`<span class="author">`).text(`Submitted by: ${storage[i].author}`);
                    let spanStatus = $(`<span class="status">`).text(`${storage[i].status} | ${storage[i].severity}`);
                    titleDiv.append(spanAuthor).append(spanStatus);
                    report.append(descrDiv).append(titleDiv);
                    container.append(report)
                }
            }
            return result;
        }
    </script>
</head>
<body>
<div id="wrapper">
    <div id="titlebar">Bug tracker</div>
    <div id="content"></div>
</div>
</body>
</html>
