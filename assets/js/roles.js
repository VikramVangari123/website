$(document).ready(function() {
    $("#select-role").val($("#select-role option:first").val());
    $("#select-industry").val($("#select-industry option:first").val());
    $('#select-role').change(function() {
        //Use $option (with the "$") to see that the variable is a jQuery object
        var $option = $(this).find('option:selected');
        //Added with the EDIT
        var value = $option.val(); //to get content of "value" attrib
        var text = $option.text(); //to get <option>Text</option> content
        if (value === 'role1') {
            $('.landing-page').css('display', 'none');
            $('.select-role').css('display', 'block');
            $('#cat1').text('Hello cat1');
            $('#cat2').text('Hello cat2');
            $('#cat3').text('Hello cat3');
            $('#cat4').text('Hello cat4');
        } else if (value === 'role2') {
            $('.landing-page').css('display', 'none');
            $('.select-role').css('display', 'block');
            $('#cat1').text('role2 cat1');
            $('#cat2').text('role2 cat2');
            $('#cat3').text('role2 cat3');
            $('#cat4').text('role2 cat4');
        } else if (value === 'role3') {
            $('.landing-page').css('display', 'none');
            $('.select-role').css('display', 'block');
            $('#cat1').text('role3 cat1');
            $('#cat2').text('role3 cat2');
            $('#cat3').text('role3 cat3');
            $('#cat4').text('role3 cat4');
        } else if (value === 'role4') {
            $('.landing-page').css('display', 'none');
            $('.select-role').css('display', 'block');
            $('#cat1').text('role4 cat1');
            $('#cat2').text('role4 cat2');
            $('#cat3').text('role4 cat3');
            $('#cat4').text('role4 cat4');
        }
    });
})