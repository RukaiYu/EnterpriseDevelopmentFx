﻿function showMyWindow(title, href, width, height, modal, minimizable, maximizable) {

    $('#myWindow').window({
        title: title,
        width: width === undefined ? 750 : width,
        height: height === undefined ? 480 : height,
        content: '<iframe scrolling="yes" frameborder="0"  src="' + href + '" style="width:100%;height:98%;"></iframe>',
        //        href: href === undefined ? null : href, 
        modal: modal === undefined ? true : modal,
        minimizable: minimizable === undefined ? false : minimizable,
        maximizable: maximizable === undefined ? false : maximizable,
        shadow: false,
        cache: false,
        closed: false,
        collapsible: false,
        resizable: false,
        loadingMessage: '正在加载数据，请稍等片刻......'
    });

}
function closeMyWindow() {
    $('#myWindow').window({
        closed: true
    });

}

function returnParent(value) {//获取子窗体返回值
    var parent = window.dialogArguments; //获取父页面
    //parent.location.reload(); //刷新父页面
    if (parent != null && parent != "undefined") {
        window.returnValue = value; //返回值
        window.close(); //关闭子页面
    }
    return;
}
function loadpage() {
    //if (window.top.location.pathname == "/Home") {

    //} else if (window.dialogArguments == null || window.dialogArguments == "undefined") {
    //    this.window.location.href = "/Admin/Account";
    //}
}
function dateConvert(value) {
    var reg = new RegExp('/', 'g');
    var d = eval('new ' + value.replace(reg, ''));
    return new Date(d).format('yyyy-MM-dd')
}

$(function () {
    //时间格式化
    Date.prototype.format = function (format) {
        /*
        * eg:format="yyyy-MM-dd hh:mm:ss";
        */
        if (!format) {
            format = "yyyy-MM-dd hh:mm:ss";
        }

        var o = {
            "M+": this.getMonth() + 1, // month
            "d+": this.getDate(), // day
            "h+": this.getHours(), // hour
            "m+": this.getMinutes(), // minute
            "s+": this.getSeconds(), // second
            "q+": Math.floor((this.getMonth() + 3) / 3), // quarter
            "S": this.getMilliseconds()
            // millisecond
        };

        if (/(y+)/.test(format)) {
            format = format.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
        }

        for (var k in o) {
            if (new RegExp("(" + k + ")").test(format)) {
                format = format.replace(RegExp.$1, RegExp.$1.length == 1 ? o[k] : ("00" + o[k]).substr(("" + o[k]).length));
            }
        }
        return format;
    };

    $.extend($.fn.datagrid.methods, {
        addToolbarItem: function (jq, items) {
            return jq.each(function () {
                var dpanel = $(this).datagrid('getPanel');
                var toolbar = dpanel.children("div.datagrid-toolbar");
                if (!toolbar.length) {
                    toolbar = $("<div class=\"datagrid-toolbar\"><table cellspacing=\"0\" cellpadding=\"0\"><tr></tr></table></div>").prependTo(dpanel);
                    $(this).datagrid('resize');
                }
                var tr = toolbar.find("tr");
                for (var i = 0; i < items.length; i++) {
                    var btn = items[i];
                    if (btn == "-") {
                        $("<td><div class=\"datagrid-btn-separator\"></div></td>").appendTo(tr);
                    } else {
                        var td = $("<td></td>").appendTo(tr);
                        var b = $("<a href=\"javascript:void(0)\"></a>").appendTo(td);
                        b[0].onclick = eval(btn.handler || function () { });
                        b.linkbutton($.extend({}, btn, {
                            plain: true
                        }));
                    }
                }
            });
        },
        removeToolbarItem: function (jq, param) {
            return jq.each(function () {
                var dpanel = $(this).datagrid('getPanel');
                var toolbar = dpanel.children("div.datagrid-toolbar");
                var cbtn = null;
                if (typeof param == "number") {
                    cbtn = toolbar.find("td").eq(param).find('span.l-btn-text');
                } else if (typeof param == "string") {
                    cbtn = toolbar.find("span.l-btn-text:contains('" + param + "')");
                }
                if (cbtn && cbtn.length > 0) {
                    cbtn.closest('td').remove();
                    cbtn = null;
                }
            });
        }
    });

})