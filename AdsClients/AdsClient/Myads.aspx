<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Myads.aspx.cs" Inherits="AdsClient.Myads" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="style.css" type="text/css" runat="server" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
    <script src="http://code.jquery.com/jquery-latest.js"></script>
      <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i" rel="stylesheet">
	<link href="https://fonts.googleapis.com/css?family=Montserrat:400,500,700" rel="stylesheet">

 		<!-- Bootstrap -->
 		<link type="text/css" rel="stylesheet" href="css/bootstrap.min.css"/>

 		<%--<!-- Slick -->--%>
 		<link type="text/css" rel="stylesheet" href="css/slick.css"/>
 		<link type="text/css" rel="stylesheet" href="css/slick-theme.css"/>

 		<!-- nouislider -->
 		<link type="text/css" rel="stylesheet" href="css/nouislider.min.css"/>

 		<!-- Font Awesome Icon -->
 		<link rel="stylesheet" href="css/font-awesome.min.css">

 		<!-- Custom stlylesheet -->
 		<link type="text/css" rel="stylesheet" href="css/style.css"/>
    <!-- Main CSS-->
    <link href="css/main.css" rel="stylesheet" media="all">
</head>
<body>
    <form id="form1" runat="server">
       
         <div class="section">
			<!-- container -->
			<div class="container">
				<!-- row -->
				<div class="row">
					<!-- ASIDE -->
		
					<div id="aside" class="col-md-2">
						<div class="sidenav">
							
					<asp:HyperLink ID="home" runat="server" href="home.aspx">Home</asp:HyperLink>
							<asp:HyperLink ID="HyperLink4" runat="server" >MyAds</asp:HyperLink>
						 <asp:HyperLink ID="HyperLink1" runat="server" href="product.aspx">Car</asp:HyperLink>
					 <asp:HyperLink ID="HyperLink2" runat="server" href="book.aspx">Book</asp:HyperLink>
					 <asp:HyperLink ID="HyperLink3" runat="server" href="laptop.aspx" >Laptop</asp:HyperLink>
            
            
				  </div>
						

						<!-- aside Widget -->
						
					</div>
					<!-- /ASIDE -->
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
					<!-- STORE -->
					<div id="store" class="col-md-10">
						<!-- store top filter -->
						
						<!-- /store top filter -->

						<!-- store products -->
						<div class="row">
                            <asp:Repeater ID="repmyads" runat="server" OnItemCommand="repmyads_ItemCommand">
								<ItemTemplate>
									<div class="col-md-4 col-xs-6">
								<div class="product">
									<div class="product-img">
										<img src='data:image/jpg;base64,<%# DataBinder.Eval(Container.DataItem,"Image1") != System.DBNull.Value ? Convert.ToBase64String((byte[])DataBinder.Eval(Container.DataItem,"Image1")) : string.Empty %>' height="300" width="420" />
										<div class="product-label">
													
													<span class="sale">
                                                       <asp:Button ID="Button1" runat="server" Text="Delete"  CommandName="DeleteRecord" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"Id") %>' OnClientClick="return confirm('Are you sure you want to Delete?')" />
													</span>
										</div>
									</div>
									<div class="product-body">
										
										<h3 class="product-name">
                                            <asp:Label ID="lbname" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Name")%>'></asp:Label></h3>
										<h4 class="product-price">&#8377;<asp:Label ID="lbprice" runat="server"  Text='<%#Eval("Price") %>'></asp:Label></h4>
										
										
									</div>
									<div class="add-to-cart">
                                       <asp:Button ID="btnupdate" runat="server" Text="Edit product" CssClass="add-to-cart-btn" CommandName="UpdateRecord" CommandArgument='<%# Eval("Id") %>' />
										
									</div>
								</div>
							</div>

									 
								</ItemTemplate>
                            </asp:Repeater>
							 
							<!-- product -->
							
							<!-- /product -->

							<!-- product -->
							
							<!-- /product -->
						</div>
						<!-- /store products -->

						<!-- store bottom filter -->
						
						<!-- /store bottom filter -->
					</div>
					<!-- /STORE -->
				</div>
				<!-- /row -->
			</div>
			<!-- /container -->
		</div>
		<!-- /SECTION -->

    </form>
</body>
</html>
