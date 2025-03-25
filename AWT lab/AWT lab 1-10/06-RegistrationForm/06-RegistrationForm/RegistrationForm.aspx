<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="_06_RegistrationForm.RegistrationForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet/StyleSheet1.css" rel="stylesheet" type="text/css" />
    <title>Registration Form</title>
     <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 class="heading">User Registration Form</h2>

            <table>
                <!-- Name Field -->
                <tr>
                    <td><asp:Label ID="Namelbl" runat="server" Text="Enter your Name:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="Nametxt" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="Nametxt" ErrorMessage="Enter Your Name" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <!-- Address Field -->
                <tr>
                    <td><asp:Label ID="Addlbl" runat="server" Text="Address:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="Addtxt" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="Addtxt" ErrorMessage="Please Enter Address" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <!-- Password Field -->
                <tr>
                    <td><asp:Label ID="Passlbl" runat="server" Text="Password:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="Passtxt" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="Passtxt" ErrorMessage="Please Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <!-- Confirm Password Field -->
                <tr>
                    <td><asp:Label ID="ConPasslbl" runat="server" Text="Confirm Password:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="ConPasstxt" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" 
                            ControlToCompare="Passtxt" ControlToValidate="ConPasstxt" 
                            ErrorMessage="Passwords Do Not Match" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>

                <!-- Email Field -->
                <tr>
                    <td><asp:Label ID="Emaillbl" runat="server" Text="Email:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="Emailtxt" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                            ControlToValidate="Emailtxt" ErrorMessage="Invalid Email Format" ForeColor="Red" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>

                <!-- Contact Number Field -->
                <tr>
                    <td><asp:Label ID="ContNolbl" runat="server" Text="Contact No:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="ContNotxt" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                            ControlToValidate="ContNotxt" ErrorMessage="Enter Valid 10-Digit Contact No" ForeColor="Red" 
                            ValidationExpression="^\d{10}$">
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>

                <!-- Age Field -->
                <tr>
                    <td><asp:Label ID="Agelbl" runat="server" Text="Age:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="Agetxt" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" 
                            ControlToValidate="Agetxt" ErrorMessage="Age must be between 18 and 100" ForeColor="Red" 
                            MinimumValue="18" MaximumValue="100" Type="Integer">
                        </asp:RangeValidator>
                    </td>
                </tr>
            </table>

            <!-- Submit Button -->
            <div class="btn-container">
                <asp:Button CssClass="btn" ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </div>

            <!-- Validation Summary -->
            <asp:ValidationSummary runat="server" ForeColor="Red" />

        </div>
    </form>
</body>
</html>
