using System;
using System.Collections.Generic;
using System.Web.Services;

namespace _24_AJAXToDoList
{
    public partial class Default : System.Web.UI.Page
    {
        private static List<string> tasks = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayTasks();
            }
        }

        protected void btnAddTask_Click(object sender, EventArgs e)
        {
            string newTask = taskInput.Value;
            if (!string.IsNullOrEmpty(newTask))
            {
                tasks.Add(newTask);
                taskInput.Value = ""; // Clear input field
                DisplayTasks();       // Refresh task list
            }
        }

        private void DisplayTasks()
        {
            taskList.InnerHtml = ""; // Clear old list

            foreach (string task in tasks)
            {
                string escapedTask = task.Replace("\"", "\\\"");
                string taskHtml = $@"
                    <div class='todo-item'>
                        <span>{task}</span>
                        <button type='button' onclick='removeTask(""{escapedTask}"")'>Remove</button>
                    </div>";
                taskList.InnerHtml += taskHtml;
            }
        }

        [WebMethod]
        public static void RemoveTask(string task)
        {
            tasks.Remove(task);
        }
    }
}
