<%@ Page Language="C#" MasterPageFile="~/MasterPages/ListView.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="DZ000001.aspx.cs" Inherits="Page_DZ000001" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/MasterPages/ListView.master" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" Runat="Server">
	<px:PXDataSource ID="ds" runat="server" Visible="True" Width="100%"
        TypeName="PRLPOSSales.PRLSalesEntry"
        PrimaryView="Sales"
        >
		<CallbackCommands>

		</CallbackCommands>
	</px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phL" runat="Server">
	<px:PXGrid ID="grid" runat="server" DataSourceID="ds" Width="100%" Height="150px" SkinID="Primary" AllowAutoHide="false">
		<Levels>
			<px:PXGridLevel DataMember="Sales">
			    <Columns>
			        			        <px:PXGridColumn DataField="RecordID" />
			        <px:PXGridColumn DataField="CompanyID" />
			        <px:PXGridColumn DataField="Customer" />
			        <px:PXGridColumn DataField="SoldToName" />
			        <px:PXGridColumn DataField="SaleDate" />
			        <px:PXGridColumn DataField="PiiPartNumber" />
			        <px:PXGridColumn DataField="PiiCategory" />
			        <px:PXGridColumn DataField="ShipQuantity" />
			        <px:PXGridColumn DataField="ExtendedSales" />
			        <px:PXGridColumn DataField="BillToCustomerZip" />
			        <px:PXGridColumn DataField="BillToCustomerState" />
			        <px:PXGridColumn DataField="SalesRep" />
			        <px:PXGridColumn DataField="ShipToState" />
			        <px:PXGridColumn DataField="ShipToZip" />
			        <px:PXGridColumn DataField="SalesRepAssignedRule" />
			        <px:PXGridColumn DataField="PeriodDate" />
			        <px:PXGridColumn DataField="CreatedByID" />
			        <px:PXGridColumn DataField="CreatedDateTime" />
			        <px:PXGridColumn DataField="LastModifiedByID" />
			        <px:PXGridColumn DataField="LastModifiedDateTime" />
			    </Columns>
			</px:PXGridLevel>
		</Levels>
		<AutoSize Container="Window" Enabled="True" MinHeight="150" />
		<ActionBar >
		</ActionBar>
	</px:PXGrid>
</asp:Content>