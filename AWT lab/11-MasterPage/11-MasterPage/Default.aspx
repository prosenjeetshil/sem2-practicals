<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_11_MasterPage.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>Welcome to Prosenjeet's Tech Blog</h2>
    <p>
        Hello there! I'm Prosenjeet — a passionate developer, MCA student, and tech enthusiast who loves sharing knowledge through code and content.
    </p>
    <p>
        This blog is where I post about everything from backend development to front-end frameworks, from Django and React.js to software testing and AI. 
        Whether you're a student, a fellow developer, or just curious about technology, there's something here for you.
    </p>
    
    <h3>What to Expect:</h3>
    <ul>
        <li>✅ Hands-on coding tutorials</li>
        <li>✅ Tips & tricks for developers</li>
        <li>✅ Solutions to real-world problems</li>
        <li>✅ Deep dives into new tech & tools</li>
    </ul>
    
    <h2>📚 Latest Blogs</h2>
    <div style="display: flex; gap: 20px; flex-wrap: wrap; justify-content: center;">
        
        <div class="blog-card">
            <img src="Img/Django.png" alt="Django Web Development" class="blog-image" />
            <h6><a href="Blog2.aspx" class="blog-link">🚀 Getting Started with Django for Web Development</a></h6>
        </div>
        
        <div class="blog-card">
            <img src="Img/ReactJS.png" alt="React.js Basics" class="blog-image" />
            <h6><a href="Blog3.aspx" class="blog-link">⚛️ Building Interactive UI with React.js</a></h6>
        </div>
        
        <div class="blog-card">
            <img src="Img/Testing.png" alt="Software Testing" class="blog-image" />
            <h6>🛠️ Introduction to Software Testing (Coming Soon)</h6>
        </div>
        
    </div>
    
    <p>Stay connected, keep learning, and let's grow together in this world of tech!</p>

    <style>
        .blog-card {
            width: 250px;
            border: 1px solid #ddd;
            padding: 15px;
            border-radius: 10px;
            box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
            text-align: center;
        }
        .blog-image {
            width: 100%;
            border-radius: 10px;
        }
        .blog-link {
            text-decoration: none;
            color: #333;
            display: block;
            margin-top: 10px;
        }
    </style>

</asp:Content>
