﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"> 

<head runat="server">
    <title>NotFound</title>
    <style>
       
        .errorIcon
        {
            padding-bottom: 25px;
            padding-left: 25px;
            padding-right: 25px;
            float: left;
            padding-top: 25px;
        }
    </style>
</head>
<body><div style="position:absolute; left:50%; top:50%; height:590px; width:1024px; margin-left:-512px;; margin-top:-295px;">

<a href="Index" id="login" class="v1">重新登陆</a>
    <div class="errorIcon">
        <img src="/Admin/Images/notfound.gif" alt="出错了" /></div>
    <div class="info">
        <h2>
            404 page not found</h2>
        <p>
            很抱歉，您的网址输入有误，请检查拼写后再尝试。</p>
    </div>  </div>
</body>
</html>
