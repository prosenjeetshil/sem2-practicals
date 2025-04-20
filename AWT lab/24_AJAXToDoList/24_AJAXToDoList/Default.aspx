<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_24_AJAXToDoList.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>To-Do List</title>
    <style>
        .todo-item {
            padding: 5px;
            margin-bottom: 5px;
            background-color: #f1f1f1;
        }
    </style>
    <script type="text/javascript">
        function removeTask(task) {
            PageMethods.RemoveTask(task, function () {
                __doPostBack('<%= UpdatePanel1.ClientID %>', '');
            });
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>To-Do List</h2>

            <!-- Input Section -->
            <div>
                <label for="taskInput">New Task: </label>
                <input type="text" id="taskInput" runat="server" />
                <asp:Button ID="btnAddTask" runat="server" Text="Add Task" OnClick="btnAddTask_Click" />
            </div>

            <!-- ScriptManager is required for AJAX -->
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true" />

            <!-- UpdatePanel -->
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div id="taskList" runat="server">
                        <%-- Tasks will appear here --%>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
