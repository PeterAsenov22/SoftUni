<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>DOM Highlighter</title>
    <script src="https://code.jquery.com/jquery-3.1.1.min.js" integrity="sha256-hVVnYaiADRTO2PzUGmuLJr8BLUSjGIZsDYGmIJLv2b8="   crossorigin="anonymous"></script>
    <style>
        #wrapper {
            width: 800px;
            overflow: hidden;
        }
        #header {
            font-size: 300%;
            font-weight: bold;
        }
        #menu {
            background-color: darkgrey;
            padding: 0.5em;
        }
        #menu a {
            margin-left: 1em;
            margin-right: 1em;
        }
        #content {
            width: 500px;
            float: left;
        }
        .article {
            padding: 2em
        }
        .article .title {
            font-size: 150%
        }
        #sidebar {
            width: 250px;
            float: right;
            background-color: lightgray;
        }
        #footer {
            text-align: center;
            clear: both;
            height: 5em;
            background-color: darkgrey;
        }
        .highlight {
            border: 1px solid red;
            background-color: pink;
        }
    </style>
</head>
<body>
<div id="wrapper">
    <div id="header">LOGO</div>
    <div id="menu"><a href="/">Menu item 1</a><a href="/">Menu item 2</a><a href="/">Menu item 3</a></div>
    <div id="content">
        <div class="article">
            <div class="title">Article title</div>
            <div class="content">
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque blandit lobortis orci non
                    vestibulum. Nullam cursus, odio id tincidunt posuere, dui elit dictum diam, in lacinia nisi nibh a
                    tortor. Aliquam suscipit sollicitudin purus quis suscipit. Aliquam ultrices ipsum neque, sit amet
                    sodales <span>libero sodales</span> sollicitudin. Vivamus molestie, augue nec aliquam lobortis,
                    ipsum orci tempor
                    ex, sit amet faucibus dolor est dictum lacus. Nam blandit interdum luctus. Maecenas at cursus urna,
                    sed elementum nunc. In faucibus eget augue nec porta. Maecenas euismod mi ut ex scelerisque
                    fermentum.</p>
                <p>Suspendisse tempus justo vitae turpis maximus congue. Nullam faucibus mauris vel volutpat vehicula.
                    Donec blandit leo et urna commodo luctus. Nam sit amet risus vitae libero accumsan venenatis. Etiam
                    id feugiat velit. In nibh enim, vestibulum ut tempus vel, pulvinar quis arcu. Fusce sit amet massa
                    ut quam volutpat commodo at a odio. Suspendisse vehicula volutpat molestie. Nulla eu accumsan
                    urna.</p>
            </div>
        </div>
        <div class="article">
            <div class="title">Article title</div>
            <div class="content"><p>Aliquam luctus maximus lacus, vel tristique ante. Quisque nisl eros, mattis in
                malesuada eu, rhoncus sit amet mi. Donec varius lectus id posuere suscipit. Interdum et malesuada fames
                ac ante ipsum primis in faucibus. Nam semper accumsan tincidunt. Nullam quis odio egestas, feugiat nisl
                sed, auctor enim. Phasellus id dui urna. In rutrum magna in ex scelerisque vehicula. Duis vitae mauris
                vel ante tempor vestibulum. Vivamus at convallis eros. Maecenas gravida lectus quam, non eleifend felis
                ullamcorper in. Suspendisse potenti. Nam imperdiet placerat convallis. </p></div>
        </div>
    </div>
    <div id="sidebar">
        <ul>
            <li><a href="/">Navigation 1</a></li>
            <li><a href="/">Navigation 2</a></li>
            <li><a href="/">Navigation 3</a></li>
        </ul>
    </div>
    <div id="footer">Copyright</div>
</div>
<div id="kor">
    <span></span>
</div>
<script>
    $(document).ready(function () {
        colorize('#content');
    });
    
    function colorize(selector) {
        let element = $(selector);

        let bestDepth = -1;
        let bestSelector;

        findDeepestChild(0, element);

        function findDeepestChild(depth, selector) {
            if (depth > bestDepth) {
                bestDepth = depth;
                bestSelector = selector;
            }

            let children = selector.children();
            for (let child of children) {
                findDeepestChild(depth + 1, $(child));
            }
        }

        while (true) {
            bestSelector.addClass('highlight');
            if (bestSelector.attr('id') == element.attr('id')) {
                return;
            }
            bestSelector = bestSelector.parent();
        }
    }
</script>
</body>
</html>
