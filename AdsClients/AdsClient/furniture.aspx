<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="AdsClient.product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="style.css" type="text/css" runat="server" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
    <script src="http://code.jquery.com/jquery-latest.js"></script>
      <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i" rel="stylesheet">

    <!-- Main CSS-->
    <link href="css/main.css" rel="stylesheet" media="all">
</head>
    
<body>
 
<div class="row">
    <div class="col-md-2">
         <div class="sidenav">
             <asp:HyperLink ID="HyperLink1" runat="server" href="product.aspx">Car</asp:HyperLink>
             <asp:HyperLink ID="HyperLink2" runat="server" href="book.aspx">Book</asp:HyperLink>
             <asp:HyperLink ID="HyperLink3" runat="server" href="laptop.aspx">Laptop</asp:HyperLink>
             <asp:HyperLink ID="HyperLink4" runat="server" href="mobile.aspx">Mobile</asp:HyperLink>
             <asp:HyperLink ID="HyperLink5" runat="server" href="furniture.aspx">Furnitue</asp:HyperLink>
            
        </div>
    </div>
    <div class="col-md-10">
    <div id="menudiv1">
        <div class="page-wrapper  p-t-10 p-b-50">
        <div class="wrapper wrapper--w900">
            <div class="card card-6">
                <div class="card-heading">
                    <h2 class="title text-dark">Post Ads for Furniture</h2>
                </div>
                <form method="POST" runat="server">
                <div class="card-body">
                  
                        <div class="form-row">
                           
                            <div class="name">Product name</div>
                            <div class="value">
                                <asp:TextBox ID="txtname" class="input--style-6" runat="server"></asp:TextBox>
                                
                            </div>
                        </div>
                    <div class="form-row">
                          
                            <div class="name">Product Brand</div>
                            <div class="value">
                                <asp:TextBox ID="txtbrand" class="input--style-6" runat="server"></asp:TextBox>
                                
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">Product Price</div>
                            <div class="value">
                                <asp:TextBox ID="txtprice" class="input--style-6" runat="server"></asp:TextBox>
                                
                            </div>
                        </div>
                         <div class="form-row">
                            <div class="name">Year</div>
                            <div class="value">
                                
                                <asp:DropDownList ID="dpyear" runat="server">
                                    <asp:ListItem>2000</asp:ListItem>
                                    <asp:ListItem>2001</asp:ListItem>
                                    <asp:ListItem>2002</asp:ListItem>
                                    <asp:ListItem>2003</asp:ListItem>
                                    <asp:ListItem>2004</asp:ListItem>
                                    <asp:ListItem>2010</asp:ListItem>
                                    <asp:ListItem>2011</asp:ListItem>
                                    <asp:ListItem>2012</asp:ListItem>
                                    <asp:ListItem>2013</asp:ListItem>
                                    <asp:ListItem>2014</asp:ListItem>
                                    <asp:ListItem>2015</asp:ListItem>
                                    <asp:ListItem>2016</asp:ListItem>
                                    <asp:ListItem>2017</asp:ListItem>
                                    <asp:ListItem>2018</asp:ListItem>
                                    <asp:ListItem>2019</asp:ListItem>
                                    <asp:ListItem>2020</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">Fuel</div>
                            <div class="value">
                                <div class="input-group">
                                    <asp:TextBox ID="txtfuel" runat="server" class="input--style-6"></asp:TextBox>
                                    

                                </div>
                            </div>
                        </div>
                       
                        <div class="form-row">
                            <div class="name">Product Description</div>
                            <div class="value">
                                <div class="input-group">
                                    <asp:TextBox ID="txtpdesc" class="textarea--style-6" runat="server" TextMode="MultiLine"></asp:TextBox>
                                    <asp:Image ID="Image1" runat="server" />
                                </div>
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">Upload Image1</div>
                            <div class="value">
                                <div class="input-group js-input-file">
                                    <asp:FileUpload ID="uploadimg1" runat="server" />

                                </div>
                                <div class="label--desc">Upload your product Images</div>
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">Upload Image2</div>
                            <div class="value">
                                <div class="input-group js-input-file">
                                    <asp:FileUpload ID="uploadimg2" runat="server" />
                                    
                             
                                </div>
                                <div class="label--desc">Upload your product Images</div>
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">Upload Image2</div>
                            <div class="value">
                                <div class="input-group js-input-file">
                                    <asp:FileUpload ID="uploadimg3" runat="server" />
                                    
                             
                                </div>
                                <div class="label--desc">Upload your product Images</div>
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name"> Sellar Name</div>
                            <div class="value">
                                <asp:TextBox ID="txtsname" class="input--style-6" runat="server"></asp:TextBox>
                                
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">Contact no.</div>
                            <div class="value">
                                <asp:TextBox ID="txtsmno" class="input--style-6" runat="server"></asp:TextBox>
                                
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">Address</div>
                            <div class="value">
                                <asp:TextBox ID="txtsaddress" class="input--style-6" runat="server"></asp:TextBox>
                                
                            </div>
                        </div>
                    
                </div>
                <div class="card-footer">
                    <asp:Button ID="Button1" runat="server" Text="Button" class="btn btn--radius-2 btn--blue-2" OnClick="Button1_Click1" />
                    
                </div>
                </form>
            </div>
        </div>
    </div>

    </div>
    
    </div>
</div>
 
 

</body>
</html>
