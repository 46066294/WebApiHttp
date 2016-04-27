$.get( "http://localhost:1570/api/client", function( data ) {
  console.log("...conexion de puta madre");
  $( "body" )
    .append( "Name: " + data.name )
    .append( "Phone: " + data.phone );
}, "json" );