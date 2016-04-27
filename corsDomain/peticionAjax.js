
$(document).ready(function(){
  
  $(function(){
      $.get( "http://localhost:1570/api/client", function( data ) {
        $( "body" ).append('<ul>');
        $.each(data, function(i,emp){
          $('ul').append('<li>' + emp.Nombre + '</li>')
          $('ul').append('<li>' + emp.Phone + '</li>')
            //$('ul').append( emp.Phone +'<br>')
        }    
        );
      
          $( "body" ).append('</ul>');
      }).error(function(){
        console.log('error');
      });
    });
    
});