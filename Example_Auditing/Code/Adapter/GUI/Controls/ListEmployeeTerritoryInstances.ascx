﻿
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_ListEmployeeTerritoryInstances" Codebehind="ListEmployeeTerritoryInstances.ascx.cs" %>
<asp:placeholder id="phHomeButton" runat="server" Visible="true">
	<asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" SkinID="ButtonSkin"/>
	&nbsp;&nbsp;&nbsp;
</asp:placeholder>
<asp:placeholder id="phAddNewButton" runat="server" Visible="true">
	<asp:button ID="btnAddNew" runat="server" Text="Add new" SkinID="ButtonSkin" OnClick="btnAddNew_Click"/>
</asp:placeholder>
<br /><br />
<llblgenpro:LLBLGenProDataSource2 ID="_EmployeeTerritoryDS" runat="server" DataContainerType="EntityCollection" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.EmployeeTerritoryEntityFactory, SD.LLBLGen.Pro.Examples.Auditing" CacheLocation="Session" EnablePaging="True" />
<asp:GridView ID="theGrid" runat="server" CssClass="Content" AutoGenerateColumns="False" DataKeyNames="EmployeeId, TerritoryId" DataSourceID="_EmployeeTerritoryDS" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" AllowSorting="True" OnRowCommand="theGrid_RowCommand">
	<Columns>
		<asp:TemplateField ShowHeader="False" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" >
			<ItemTemplate>
				<asp:Button ID="btnViewExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="ViewExisting" Text="View" SkinID="ButtonSkin" />
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField ShowHeader="False" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders">
			<ItemTemplate>
				<asp:Button ID="btnEditExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="EditExisting" Text="Edit" SkinID="ButtonSkin" />
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField ShowHeader="False" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left">
			<ItemTemplate>
				<asp:Button ID="btnDeleteExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="Delete" Text="Delete" SkinID="ButtonSkin" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this EmployeeTerritory instance with PK values: "  + "EmployeeId: " + Eval("EmployeeId") + ", " + "TerritoryId: " + Eval("TerritoryId") + " ?\");" %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="EmployeeId" SortExpression="EmployeeId" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:HyperLink ID="lnkEmployeeId" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.EmployeeEntity).ToString() + "&EmployeeId=" + Eval("EmployeeId")%>' Text='<%# Bind("EmployeeId") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="TerritoryId" SortExpression="TerritoryId" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:HyperLink ID="lnkTerritoryId" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.TerritoryEntity).ToString() + "&TerritoryId=" + Eval("TerritoryId")%>' Text='<%# Bind("TerritoryId") %>'/>
			</ItemTemplate>
		</asp:TemplateField>

	</Columns>
	<PagerStyle CssClass="headers" HorizontalAlign="Center" />
	<HeaderStyle CssClass="tableheaders" />
</asp:GridView>
