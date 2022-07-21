<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IntelliSenseSearch.aspx.cs" Inherits="IntelliSenseSearch.IntelliSenseSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Intellisense Search</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Dynamic Car Search</h1>
            <asp:TextBox runat="server" ID="searchBox"></asp:TextBox>
            <asp:DropDownList runat="server" ID="list">

            </asp:DropDownList>
        </div>
    </form>

    <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script>
        const searchBox = document.getElementById("searchBox");
        const dropdown = document.getElementById("list");

        searchBox.addEventListener("input", () => {
            let query = searchBox.value;
            $.ajax({
                url: 'IntelliSenseSearch.aspx/IntelliSense',
                type: 'post',
                data: JSON.stringify({ "query": query }),
                contentType: 'application/json',
                async: true,
                success: function(data) {
                    if (data.d !=[]) {
                        //ADD comments
                        $("#list").empty()
                        let carArr = data.d;
                        carArr.forEach((car) => {
                            let option = document.createElement("option");
                            option.innerText = car;
                            option.classList.add("open")
                            dropdown.appendChild(option);
                            console.log(carArr)
                        })
                    }
                    else {
                        throw new DOMException("Invalid value supplied");
                    }
                }
            });
        })
    </script>
</body>
</html>
