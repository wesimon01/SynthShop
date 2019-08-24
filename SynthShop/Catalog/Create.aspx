<%@ Page Title="Create" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" ValidateRequest="false" CodeBehind="Create.aspx.cs" Inherits="SynthShop.Catalog.Create" %>

<asp:Content ID="Create" ContentPlaceHolderID="MainContent" runat="server">

    <h2 class="esh-body-title">Create</h2>

    <div>
        <div class="form-horizontal">
            <div class="form-group">
                <label class="control-label col-md-2">Name</label>
                <div class="col-md-3">
                    <asp:TextBox ID="Name" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Name" Display="Dynamic"
                        CssClass="field-validation-valid text-danger" ErrorMessage="The Name field is required." />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2">Description</label>
                <div class="col-md-3">
                    <asp:TextBox ID="Description" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2">Manufacturer</label>
                <div class="col-md-3">
                    <asp:DropDownList ID="Manufacturer" runat="server"
                        SelectMethod="GetManufacturers"
                        ItemType="SynthShopData.Models.CatalogManufacturer"
                        DataTextField="Manufacturer"
                        DataValueField="Id"
                        CssClass="form-control">
                    </asp:DropDownList>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2">Type</label>
                <div class="col-md-3">
                    <asp:DropDownList ID="Type" runat="server"
                        SelectMethod="GetTypes"
                        ItemType="SynthShopData.Models.CatalogType"
                        DataTextField="Type"
                        DataValueField="Id"
                        CssClass="form-control">
                    </asp:DropDownList>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2">Price</label>
                <div class="col-md-3">
                    <asp:TextBox ID="Price" runat="server" CssClass="form-control">0.00</asp:TextBox>
                    <asp:RangeValidator runat="server" ControlToValidate="Price" Type="Currency" CssClass="text-danger" Display="Dynamic"
                        MinimumValue="0" MaximumValue="1000000" ErrorMessage="The Price must be a positive number with maximum two decimals between 0 and 1 million." />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2">Picture name</label>
                <div class="col-md-4 esh-form-information">
                    Uploading images not allowed for this version.
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2">Stock</label>
                <div class="col-md-3">
                    <asp:TextBox ID="Stock" runat="server" CssClass="form-control">0</asp:TextBox>
                    <asp:RangeValidator runat="server" ControlToValidate="Stock" Type="Integer" CssClass="text-danger" Display="Dynamic"
                        MinimumValue="0" MaximumValue="100000" ErrorMessage="The field Stock must be between 0 and 100000" />
                </div>
            </div>

            <div class="form-group">
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
                    <asp:Button CssClass="btn esh-button esh-button-primary" runat="server" Text="[ Create ]"
                        OnClick="Create_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
