$(document).ready(function () {

    // Equal Height
    $('.Textbox').matchHeight();

    /* AJAX AND SESSION*/
    function Search(page, url) {
        $.ajax({
            url: url + page,
        }).done(function (data) {
            $("#ResultsWrapper").html(data);         
        });
    }

    // Normal CLick Handling
    $('body').on('click','.pageLinkAjax',function(){
        var newPage = $(this).attr("pageNumber");
        Search(newPage, "/SearchPageAjax/GetSearchResults?Page=");
    });

    // Session Click Handling
    $('body').on('click', '.pageLinkAjaxSession', function () {
        var newPage = $(this).attr("pageNumber");
        Search(newPage, "/SearchPageAjaxSession/GetSearchResults?Page=");
    });

    /* ENDE AJAX */

    /* AJAX History Push*/
    function SearchHistoryPush(page) {
        $.ajax({
            url: "/SearchPageAjaxHistoryPush/GetSearchResults?Page=" + page,
        }).done(function (data) {
            $("#ResultsWrapper").html(data);
            if (history.pushState) {
                var params = { page: page };
                var urlParams = $.param(params);
                var url = window.location.href.split('?')[0];
                var newUrl = url + "?" + urlParams;
                history.pushState({}, null, newUrl);
            }
        });
    }

    $('body').on('click', '.pageLinkAjaxHistory', function () {
        var newPage = $(this).attr("pageNumber");
        SearchHistoryPush(newPage);
    });

    /* ENDE AJAX */

    /* QUERY PARAMETER */

    $(".pageLinkQuery").click(function ()
    {
        var newPage = $(this).attr("pageNumber");
        var params = { page: newPage };
        var urlParams = $.param(params);
        var url = window.location.href.split('?')[0];
        document.location.href = url + "?" + urlParams;
    });

    /* END QUERY */
});