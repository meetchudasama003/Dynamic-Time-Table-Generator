function calculateTotalHours() {
    var noOfWorkingDays = parseInt(document.getElementById('NoOfWorkingDays').value);
    var noOfSubjectsPerDay = parseInt(document.getElementById('NoOfSubjectsPerDay').value);

    if (!isNaN(noOfWorkingDays) && !isNaN(noOfSubjectsPerDay)) {
        // Calculate total hours and display it
        var totalHours = noOfWorkingDays * noOfSubjectsPerDay;
        document.getElementById('TotalHours').value = totalHours;
    } else {
        document.getElementById('TotalHours').value = '';
    }
}

// Add event listeners to update total hours when input changes
document.getElementById('NoOfWorkingDays').addEventListener('input', calculateTotalHours);
document.getElementById('NoOfSubjectsPerDay').addEventListener('input', calculateTotalHours);