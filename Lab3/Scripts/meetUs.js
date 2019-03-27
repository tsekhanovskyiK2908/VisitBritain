


function setDateAndTime() {
    var today = new Date();   
    var dateFromInput = document.getElementById('date-input').value;
    var date = new Date(dateFromInput);
    var timeFromInput = document.getElementById('time-input').value;    
    date.setHours(0,0,0,0);    


    if(!dateFromInput) {
        alert('Set the date');
    } else if(date<today) {        
        alert('We unable to meet you in past =)');
    } else {
        if(!timeFromInput) {
            alert('Set the time');
        } else { // condition to expand            
            alert('The date you choose is '+date+'. The time you choose is '+timeFromInput );
        }
    }
    
}