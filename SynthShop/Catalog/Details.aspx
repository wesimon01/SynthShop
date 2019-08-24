<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="SynthShop.Catalog.Details" %>
<asp:Content ID="Details" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="esh-body-title">Details</h2>

    <div class="container">
        <div class="row">
            <asp:Image runat="server" CssClass="col-md-9 esh-picture" ImageUrl='<%#"/ItemPics/" + product.PictureFileName%>' />
            <dl class="col-md-3 dl-horizontal">
                
                <dt>Name</dt>
                <dd>
                    <asp:Label runat="server" Text='<%#product.Name%>' />
                </dd>

                <dt>Manufacturer</dt>
                <dd>
                    <asp:Label runat="server" Text='<%#product.CatalogManufacturer.Manufacturer%>' />
                </dd>

                <dt>Polyphony</dt>
                <dd>
                    <asp:Label runat="server" Text='<%#itemSpecs.Polyphony%>' />
                </dd>

                <dt>Oscillators</dt>
                <dd>
                    <asp:Label runat="server" Text='<%#itemSpecs.Oscillators%>' />
                </dd>
                
                <dt>Lfo</dt>
                <dd>
                    <asp:Label runat="server" Text='<%#itemSpecs.Lfo%>' />
                </dd>

                <dt>Filter</dt>
                <dd>
                    <asp:Label runat="server" Text='<%#itemSpecs.Filter%>' />
                </dd>

                <dt>Effects</dt>
                <dd>
                    <asp:Label runat="server" Text='<%#itemSpecs.Effects%>' />
                </dd>

                <dt>Keyboard</dt>
                <dd>
                    <asp:Label runat="server" Text='<%#itemSpecs.Keyboard%>' />
                </dd>

                <dt>Memory</dt>
                <dd>
                    <asp:Label runat="server" Text='<%#itemSpecs.Memory%>' />
                </dd>

                <dt>Date Produced</dt>
                <dd>
                    <asp:Label runat="server" Text='<%#itemSpecs.DateProduced%>' />
                </dd>

            </dl>
        </div>

        <div class="form-actions no-color esh-link-list">
            <a runat="server" href='<%# GetRouteUrl("EditProductRoute", new {id = product.Id}) %>' class="esh-link-item">Edit
            </a>
            |
            <a runat="server" href="~" class="esh-link-item">Back to list</a>
        </div>
    </div>
</asp:Content>