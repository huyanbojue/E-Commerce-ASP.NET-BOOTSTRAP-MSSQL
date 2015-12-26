<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="yonetim.aspx.cs" Inherits="WebApplication3.yonetim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div  class="col-lg-4">

        <img src="resimler/10.png" />
    </div>
    <div class="col-lg-5">
    <h1>Ürün Ekle</h1>
    <form>
  <div class="form-group">
    <label for="exampleInputEmail1">Ürün Adı</label>
    <input type="email" class="form-control" id="TextBox1" placeholder="Ürün Adı">
  </div>
          <div class="form-group">
    <label for="exampleInputEmail1">Özellikleri</label>
    <input type="email" class="form-control" id="aciklama" placeholder="açıklama">
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Fiyatı</label>
    <input type="password" class="form-control" id="exampleInputPassword1" placeholder="Fiyatı">
  </div>
  <div class="form-group">
    <label for="exampleInputFile">Resim Seç</label>
    <input type="file" id="FileUpload1">
    <p class="help-block">Ekleyeceğiniz Ürün için bir fotoğraf eklemelisiniz</p>
  </div>
  <button type="submit" class="btn btn-default" id="btn1" onclick="btn1_click">Kaydet</button>
        <br />
</form>
        </div>

    <div class="col-lg-3">
        <img src="resimler/duyuru.png" />
    </div>
</asp:Content>
