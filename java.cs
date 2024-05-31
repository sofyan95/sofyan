function calculate() {
    var loanAmount = parseFloat(document.getElementById('loan-amount').value);
    var loanTerm = parseFloat(document.getElementById('loan-term').value);
    
    var monthlyPayment = (loanAmount / loanTerm).toFixed(2);
    
    document.getElementById('result').innerHTML = 'Pembayaran Bulanan: Rp ' + monthlyPayment;
}
