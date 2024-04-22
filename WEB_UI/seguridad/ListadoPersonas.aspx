<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="ListadoPersonas.aspx.cs" Inherits="WEB_UI.seguridad.ListadoPersons" %>
<asp:Content ID="Content1" ContentPlaceHolderID="myHead" runat="server">

    <table id="example" class="display nowrap" style="width:100%">
        <thead>
            <tr>
                <th>CODIGO</th>
                <th>USUARIO</th>
                <th>NOMBRE</th>
                <th>EDAD</th>
                <th>FECHA NACIMIENTO</th>
                <th>ESTADO</th>
            </tr>
        </thead>
        <tbody>
            
          
            <tr>
                <td>1</td>
                <td>gsicaja</td>
                <td>Gustavo Adolfo Sicaja Galicia</td>
                <td>34</td>
                <td>2012-09-26</td>
                <td>ACTIVO</td>
            </tr>
            <tr>
                <td>2</td>
                <td>sescobar</td>
                <td>Sara Isabel Escobar Escobar </td>
                <td>30</td>
                <td>2011-09-03</td>
                <td>ACTIVO</td>
            </tr>
            <tr>
                <td>3</td>
                <td>descobar</td>
                <td>Darlin Anahi Sicaja Escobar</td>
                <td>40</td>
                <td>2009-06-25</td>
                <td>INACTIVO</td>
            </tr>
              <tr>
      <td>1</td>
      <td>gsicaja</td>
      <td>Gustavo Adolfo Sicaja Galicia</td>
      <td>34</td>
      <td>2012-09-26</td>
      <td>ACTIVO</td>
  </tr>
  <tr>
      <td>2</td>
      <td>sescobar</td>
      <td>Sara Isabel Escobar Escobar </td>
      <td>30</td>
      <td>2011-09-03</td>
      <td>ACTIVO</td>
  </tr>
  <tr>
      <td>3</td>
      <td>descobar</td>
      <td>Darlin Anahi Sicaja Escobar</td>
      <td>40</td>
      <td>2009-06-25</td>
      <td>INACTIVO</td>
  </tr>
     <tr>
      <td>1</td>
      <td>gsicaja</td>
      <td>Gustavo Adolfo Sicaja Galicia</td>
      <td>34</td>
      <td>2012-09-26</td>
      <td>ACTIVO</td>
  </tr>
  <tr>
      <td>2</td>
      <td>sescobar</td>
      <td>Sara Isabel Escobar Escobar </td>
      <td>30</td>
      <td>2011-09-03</td>
      <td>ACTIVO</td>
  </tr>
  <tr>
      <td>3</td>
      <td>descobar</td>
      <td>Darlin Anahi Sicaja Escobar</td>
      <td>40</td>
      <td>2009-06-25</td>
      <td>INACTIVO</td>
  </tr>
     <tr>
      <td>1</td>
      <td>gsicaja</td>
      <td>Gustavo Adolfo Sicaja Galicia</td>
      <td>34</td>
      <td>2012-09-26</td>
      <td>ACTIVO</td>
  </tr>
  <tr>
      <td>2</td>
      <td>sescobar</td>
      <td>Sara Isabel Escobar Escobar </td>
      <td>30</td>
      <td>2011-09-03</td>
      <td>ACTIVO</td>
  </tr>
  <tr>
      <td>3</td>
      <td>descobar</td>
      <td>Darlin Anahi Sicaja Escobar</td>
      <td>40</td>
      <td>2009-06-25</td>
      <td>INACTIVO</td>
  </tr>
   
   
           
        </tbody>
        <tfoot>
            <tr>
                <th>CODIGO</th>
                <th>USUARIO</th>
                <th>NOMBRE</th>
                <th>EDAD</th>
                <th>FECHA NACIMIENTO</th>
                <th>ESTADO</th>
            </tr>
        </tfoot>
    </table>
    <script src="https://code.jquery.com/jquery-3.7.1.js" type="text/javascript"></script>
    <script src="https://cdn.datatables.net/2.0.5/js/dataTables.js" type="text/javascript"></script>
    <script src="https://cdn.datatables.net/responsive/3.0.2/js/dataTables.responsive.js" type="text/javascript"></script>
    <script src="https://cdn.datatables.net/responsive/3.0.2/js/responsive.dataTables.js" type="text/javascript"></script>

    <script src="https://cdn.datatables.net/buttons/3.0.2/js/dataTables.buttons.js" type="text/javascript"></script>
    <script src="https://cdn.datatables.net/buttons/3.0.2/js/buttons.dataTables.js" type="text/javascript"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jszip/3.10.1/jszip.min.js" type="text/javascript"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.2.7/pdfmake.min.js" type="text/javascript"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.2.7/vfs_fonts.js" type="text/javascript"></script>
    <script src="https://cdn.datatables.net/buttons/3.0.2/js/buttons.html5.min.js" type="text/javascript"></script>
    <script src="https://cdn.datatables.net/buttons/3.0.2/js/buttons.print.min.js" type="text/javascript"></script>













    <script type="text/javascript">
        new DataTable('#example', {
            
            responsive: true, "lengthChange": true, "autoWidth": true,

            layout: {
                topStart: {
                    buttons: [
                        'csv',
                        {
                           
                            extend: 'csv',
                            text: '<i class="fas fa-file-csv" style="font-size: 20px"></i>',
                            filename: 'archivoEncsv',
                            title: ''
                        },
                        {

                            extend: 'copy',
                            text: '<i class="far fa-clone" style="font-size: 20px"></i>',
                            title: ''
                        },
                        {
                            extend: 'excel',
                            text: '<i class="far fa-file-excel" style="font-size: 20px"></i>',
                            filename: 'archivoEnExcel',
                            title: ''
                        },
                        {
                            extend: 'print',
                            text: '<i class="fas fa-print" style="font-size: 20px"></i>',
                            filename: 'archivoEnpdf',
                            title: ' impresion '
                        }]

                },
                bottomEnd: {
                    paging: {
                        boundaryNumbers: false
                    }
                }
            }
        });
    </script>
</asp:Content>
