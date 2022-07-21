<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccessInfo.aspx.cs" Inherits="AccessStudentInfo.AccessInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Select any name to display the complete information!</h1>
            <asp:DropDownList runat="server" ID="list"></asp:DropDownList>
            <p id="name"></p>
            <p id="Id"></p>
            <p id="adminyear"></p>

        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script>
        const dropdown = document.getElementById("list");
        dropdown.addEventListener("change", () => {
            let queryIndex = $("#list option:selected").index()
            $.ajax({
                url: 'AccessInfo.aspx/Answer',
                type: 'post',
                data: JSON.stringify({ "queryIndex": queryIndex }),
                contentType: 'application/json',
                async: true,
                success: function (data) {
                    if (data.d) {
                        console.log(data.d);
                        $("#name").text(`Name: ${data.d.Name}`);
                        $("#Id").text(`RollNo : ${data.d.Id}`);
                        $("#adminyear").text(`Admission Year: ${data.d.AdmissionYear}`);


                    }
                    else {
                        $("#result").text("Error...");
                        console.log(data);

                        throw new DOMException("Invalid value supplied");
                    }
                }
            });
            console.log("Ajax ran");
        })
    </script>
</body>
</html>