<%@ Page Title="Threads" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
         CodeBehind="ThreadList.aspx.cs" Inherits="TBForumPage.ThreadList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
	<section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Page.Title %></h1>
            </hgroup>
                 <section class="featured">
                    <ul> 
                        <asp:ListView ID="threadList" runat="server"
                            DataKeyNames="ThreadID" ItemType="TBForumPage.Models.Thread" SelectMethod="GetThreads">
                            <EmptyDataTemplate>      
                                <table id="Table1" runat="server">        
                                    <tr>          
                                        <td>No data was returned.</td>        
                                    </tr>     
                                </table>  
                            </EmptyDataTemplate>  
                            <EmptyItemTemplate>     
                                <td id="Td1" runat="server" />  
                            </EmptyItemTemplate>  
                            <GroupTemplate>    
                                <tr ID="itemPlaceholderContainer" runat="server">      
                                    <td ID="itemPlaceholder" runat="server"></td>    
                                </tr>  
                            </GroupTemplate>  
                            <ItemTemplate>    
                                <td id="Td2" runat="server">      
                                    <table>        
                                        <tr>          
                                            <td>&nbsp;</td>          
                                            <td>
                                                <a href="ThreadDetails.aspx?productID=<%#:Item.ThreadID%>">
                                                    <img src="/Catalog/Images/<%#:Item.ImagePath%>" 
                                                        width="100" height="75" border="0"/>
                                                </a> 
                                            </td>
                                            <td>
                                                <a href="ThreadDetails.aspx?productID=<%#:Item.ThreadID%>">
                                                    <span class="ProductName">
                                                        <%#:Item.ThreadName%>
                                                    </span>
                                                </a>          
                                            </td>  
                                        </tr>      
                                    </table>    
                                </td>  
                            </ItemTemplate>  
                            <LayoutTemplate>    
                                <table id="Table2" runat="server">      
                                    <tr id="Tr1" runat="server">        
                                        <td id="Td3" runat="server">          
                                            <table ID="groupPlaceholderContainer" runat="server">            
                                                <tr ID="groupPlaceholder" runat="server"></tr>          
                                            </table>        
                                        </td>      
                                    </tr>      
                                    <tr id="Tr2" runat="server"><td id="Td4" runat="server"></td></tr>    
                                </table>  
                            </LayoutTemplate>
                        </asp:ListView>
                    </ul>
               </section>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
