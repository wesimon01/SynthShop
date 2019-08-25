<%@ Page Language="C#" Debug="true" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditSpecs.aspx.cs" ValidateRequest="false" Inherits="SynthShop.Catalog.EditSpecs" %>

<asp:Content runat="server" ID="EditSpecs" ContentPlaceHolderID="MainContent">
    <h2 class="esh-body-title">Edit specs</h2>

    <div class="container">
        <div class="row">
            <asp:Image runat="server" CssClass="col-md-6 esh-picture" ImageUrl='<%#"/ItemPics/" + product.PictureFileName %>'/>
            <div class="form-group">
            <div class="col-md-6 form-horizontal">

                <label class="control-label col-md-2">Polyphony</label>
                <div class="col-md-3">
                    <asp:TextBox ID="Polyphony" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2">Oscillators</label>
                <div class="col-md-3">
                    <asp:TextBox ID="Oscillators" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2">Lfo</label>
                <div class="col-md-3">
                    <asp:TextBox ID="Lfo" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2">Filter</label>
                <div class="col-md-3">
                    <asp:TextBox ID="Filter" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2">Effects</label>
                <div class="col-md-3">
                    <asp:TextBox ID="Effects" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2">Keyboard</label>
                <div class="col-md-3">
                    <asp:TextBox ID="Keyboard" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2">Memory</label>
                <div class="col-md-3">
                    <asp:TextBox ID="Memory" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2">Date Produced</label>
                <div class="col-md-3">
                    <asp:TextBox ID="DateProduced" runat="server" CssClass="form-control">0</asp:TextBox>
                    <asp:RangeValidator runat="server" ControlToValidate="DateProduced" Type="Integer" CssClass="text-danger" Display="Dynamic"
                        MinimumValue="1935" MaximumValue="2050" ErrorMessage="Must be a valid date" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-3 text-right esh-button-actions">
                    <a runat="server" href="~" class="btn esh-button esh-button-secondary"> [ Cancel ] </a>
                    <asp:Button CssClass="btn esh-button esh-button-primary" runat="server" Text="[ Save ]"
                        OnClick="Save_Click" />
                </div>
            </div>
        </div>
     </div>
</div>    
</asp:Content>
  