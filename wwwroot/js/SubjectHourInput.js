$(document).ready(function () {
    console.log("validatesubject");

    $("#subjectHoursForm").submit(function (e) {
        var isValid = true;
        $(".error-message").hide();  // Hide previous errors
        var maxHours = parseInt($('#TotalHours').val());  // Max hours
        var totalInputHours = 0;  // Total of input hours

        // Iterate over all input fields for subject hours
        $("[id^=SubjectHours_]").each(function (index) {
            var hours = parseInt($(this).val());
            var minHours = 1;

            if (isNaN(hours) || hours < minHours || hours > maxHours) {
                isValid = false;
                $("#error_" + index).show();
            }

            totalInputHours += hours;
        });

        // Check if the total input hours greater than allowed hours
        if (totalInputHours > maxHours || totalInputHours < maxHours) {
            isValid = false;
            var message = "The total input hours (" + totalInputHours + ") do not match the required hours (" + maxHours + "). Please adjust the subject hours.";
            alert(message);
        }

        // if form is not valid,then prevent submission
        if (!isValid) {
            e.preventDefault();
        }
    });
});
