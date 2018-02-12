$(function () {
    var currentpost = 10;
   
    $(window).scroll(function () {

        if ((window.innerHeight + window.pageYOffset) > $(document).height() - 200) {

            $.ajax({
                url: "http://localhost:65458/Ajax/GetPosts?skip=" + currentpost + "&take=10",
                type: "POST",
                dataType: "json",
                success: function (res) {
                    
                    console.log(res);
                    currentpost += 10;
                   

                    for (var i = 0; i < res.response.length; i++) {
                        var text = res.response[i].Content;
                        var substext = text.substring(0, 200);     
                        var id = res.response[i].Id;
                        
               
                        

                        $(".col-md-8").append('<div class="card mb-4">' +
                            '<img class="card-img-top" src= "/Uploads/' + res.response[i].Photo + '">'
                            + '<div class="card-body">' + '<h2 class="card-title">' + res.response[i].Title + '</h2>'

                            + (text.length > 200 ? '<p class="card-text">' + substext + '&hellip;</p>' : '')
                            + '<a href="ReadMore/Details/' + id + '" class="btn btn-primary">Read More &rarr;</a>'
                            + '</div>'
                            + '<div class="card-footer text-muted">Posted on ' + res.response[i].Dateline +' by '                          
                            + '<a href="#">Start Bootstrap</a>'
                            + '</div>'                           
                            + '</div>');    


                       

                    }
                   
                }
            });

        }      

    })
    


});





