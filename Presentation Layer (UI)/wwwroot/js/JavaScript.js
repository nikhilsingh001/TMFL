$(document).ready(function () {

    GetDesc();
    Getregion();

    $("#ddlRegion").change(function () {

        var id = $(this).val();
        $("#ddlzone").empty();
        $("#ddlzone").append("<Option>--select---</Option");


        $.ajax({
            url: "/Emp/ZOne?id=" + id,
            success: function (resul) {

                $.each(resul, function (i, data) {
                    $("#ddlzone").append("<Option value=" + data.id + ">" + data.zonename + "</Option")
                })
            }

        })

    });


    $("#ddlzone").change(function () {

        var id = $(this).val();
        $("#ddlbrach").empty();
        $("#ddlbrach").append("<Option>--select---</Option");


        $.ajax({
            url: "/Emp/branch?id=" + id,
            success: function (resul) {

                $.each(resul, function (i, data) {
                    $("#ddlbrach").append("<Option value=" + data.id + ">" + data.branchName + "</Option")
                })
            }

        })

    });

    /*    $('#date').datepicker();*/

    //Mod();
    hidemodel();
    pop();
    $("#date").datepicker()
    MutExChkList(chk);



});


function GetDesc() {
    $.ajax({
        url: "/Emp/Designations",
        success: function (resul) {

            $.each(resul, function (i, data) {
                $("#ddldes").append("<Option value=" + data.id + ">" + data.designationName + "</Option")
            })
        }

    })

}

function Getregion() {

    $.ajax({
        url: "/Emp/Region",
        success: function (resul) {

            $.each(resul, function (i, data) {
                $("#ddlRegion").append("<Option value=" + data.id + ">" + data.regionname + "</Option")
            })
        }

    })

}


function MutExChkList(chk) {

    /*var chkList = chk.parentNode.parentNode.parentNode;*/
    var chkList = chk.parentNode;
    var chks = chkList.getElementsByTagName("input");
    for (var i = 0; i < chks.length; i++) {
        if (chks[i] != chk && chk.checked) {
            chks[i].checked = false;
        }
    }
}




function pop() {
    $("#myTable .details").click(function () {
        debugger;
        var customerId = $(this).closest("tr").find("td").eq(0).html().toString().trim();
        $.ajax({
            type: "POST",
            url: "/Emp/Paritalmod",
            data: { "customerId": customerId },
            success: function (response) {
                $("#partialModal").find(".modal-body").html(response);
                $("#partialModal").modal('show');
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
    });
}




function Val() {
    debugger;
    if ($('#txtempid').val() == null || $('#txtempid').val() == "") {
        alert("please enter the empid")
        return false;

    } else if
        (($('#txtempname').val() == null || $('#txtempname').val() == "")) {
        alert("please enter the empname")
        return false;

    }

   

    
    else if
        (($('input[name=Gender]:checked').val() == null || $('input[name=Gender]:checked').val() == "")) {
        alert("please Select Gender")
        return false;

    } 
    else if
        (($('#ddldes option:selected').val() == null || $('#ddldes option:selected').val() == "--select Designation ---")) {
        alert("please Select Designation")
        return false;

    } else if
        (($('#ddlRegion option:selected').val() == null || $('#ddlRegion option:selected').val() == "--select Region ---")) {
        alert("please Select Region")
        return false;

    }
    
    else if
        (($('#ddlzone option:selected').val() == null || $('#ddlzone option:selected').val() == "--select---")) {
        alert("please Select Zone")
        return false;

    }
    else if
        (($('#ddlbrach option:selected').val() == null || $('#ddlbrach option:selected').val() == "--select---")) {
        alert("please Select Brach")
        return false;

    }
    else if
        (($('input[name=ListTech]:checked').val() == null || $('input[name=ListTech]:checked').val() == "")) {
        alert("please Select Technology")
        return false;

    }
    else if
        (($('#date').val() == null || $('#date').val() == "")) {
        alert("please Select Date")
        return false;

    }
    else if
        (($('#txtemail').val() == null || $('#date').val() == "") || $('#txtemail').val().indexOf('@') == -1) {
        alert("please vaild Email")
        return false;

    }
    else if ($('#txtmob').val().length == 10 || $('#txtmob').val() == null || $('#txtmob').val() == "") {
        alert("please vaild Mobile")
        return false;

    } else if
        (($('#txtAdd').val() == null || $('#txtAdd').val() == "")) {
        alert("please enter the Address")
        return false;

    } else
        if (document.getElementById("file").files.length == 0) {
            alert("please select file ")
            return false;
    }
    document.form.submit();
    return true;


}

function hidemodel()
{

    $(".close").click(function () {
        debugger;
        $("#partialModal").modal('hide');

    })


    $("#btnclose").click(function () {
        debugger;
        $("#partialModal").modal('hide');

    })
  
 

}