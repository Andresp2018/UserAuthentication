﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="UserAuthentication.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link href="https://fonts.googleapis.com/css?family=Roboto:300,400&display=swap" rel="stylesheet">

    <link rel="stylesheet" href="fonts/icomoon/style.css">

    <link rel="stylesheet" href="css/owl.carousel.min.css">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="css/bootstrap.min.css">

    <!-- Style -->
    <link rel="stylesheet" href="css/style-login.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <div class="container">
                <div class="row justify-content-center">
                    <!-- <div class="col-md-6 order-md-2">
          <img src="images/undraw_file_sync_ot38.svg" alt="Image" class="img-fluid">
        </div> -->
                    <div class="col-md-6 contents">
                        <div class="row justify-content-center">
                            <div class="col-md-12">
                                <div class="form-block">
                                    <div class="mb-4">
                                        <h3>Sign In to <strong>.NET wonders</strong></h3>
                                        <p class="mb-4">Welcome traveller!</p>
                                    </div>
                                    </div>
                                        <div class="form-group first">
                                            <label for="username">Email</label>
                                            <asp:TextBox ID="tb_username" class="form-control" runat="server" TextMode="Email"></asp:TextBox>
                                        </div>
                                        <div class="form-group last mb-4">
                                            <label for="password">Password</label>
                                            <asp:TextBox ID="tb_password" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
                                        </div>
                                        <div class="d-flex mb-5 align-items-center">
                                            <label class="control control--checkbox mb-0">
                                                <span class="caption">Remember me</span>
                                                <input type="checkbox" checked="checked" />
                                                <div class="control__indicator"></div>
                                            </label>
                                            <span class="ml-auto"><a href="#" class="forgot-pass">Forgot Password</a></span>
                                        </div>

                                        <asp:Button ID="btn_login" class="btn btn-pill text-white btn-block btn-primary" runat="server" Text="Submit" OnClick="btn_login_Click" />
                                        <asp:Button ID="btn_register" class="btn btn-pill text-white btn-block btn-primary" runat="server" Text="Register" OnClick="btn_register_Click" />
                                        <span class="d-block text-center my-4 text-muted">or sign in with</span>

                                        <div class="social-login text-center">
                                            <a href="#" class="facebook">
                                                <span class="icon-facebook mr-3"></span>
                                            </a>
                                            <a href="#" class="twitter">
                                                <span class="icon-twitter mr-3"></span>
                                            </a>
                                            <a href="#" class="google">
                                                <span class="icon-google mr-3"></span>
                                            </a>
                                        </div>
                                </div>
                            </div>
                        </div>

                    </div>

                </div>
            </div>
        </div>


        <script src="js/jquery-3.3.1.min.js"></script>
        <script src="js/popper.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
        <script src="js/main.js"></script>
    </form>
</body>
</html>
