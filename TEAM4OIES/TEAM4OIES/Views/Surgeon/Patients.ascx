<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<TEAM4OIES.DataSet1+PatientDataTable>" %>

    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">Count</div>
        <div class="display-field"><%: Model.Count %></div>
        
        <div class="display-label">CaseSensitive</div>
        <div class="display-field"><%: Model.CaseSensitive %></div>
        
        <div class="display-label">IsInitialized</div>
        <div class="display-field"><%: Model.IsInitialized %></div>
        
        <div class="display-label">DisplayExpression</div>
        <div class="display-field"><%: Model.DisplayExpression %></div>
        
        <div class="display-label">HasErrors</div>
        <div class="display-field"><%: Model.HasErrors %></div>
        
        <div class="display-label">MinimumCapacity</div>
        <div class="display-field"><%: Model.MinimumCapacity %></div>
        
        <div class="display-label">TableName</div>
        <div class="display-field"><%: Model.TableName %></div>
        
        <div class="display-label">Namespace</div>
        <div class="display-field"><%: Model.Namespace %></div>
        
        <div class="display-label">Prefix</div>
        <div class="display-field"><%: Model.Prefix %></div>
        
        <div class="display-label">DesignMode</div>
        <div class="display-field"><%: Model.DesignMode %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Edit", "Edit", new { /* id=Model.PrimaryKey */ }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>


