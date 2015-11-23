function Calculate(BiayaPNBPClientID, BiayaAdmClientID, BiayaIuranClientID, BiayaPilihCallSignClientID, BiayaUangPangkalClientID, TotalBiayaClientID)
{
    var BiayaPNBP = document.getElementById(BiayaPNBPClientID).value.replace(/, /, "");
    var BiayaAdm = document.getElementById(BiayaAdmClientID).value.replace(/, /, "");
    var BiayaIuran = document.getElementById(BiayaIuranClientID).value.replace(/, /, "");
    var BiayaPilihCallSign = document.getElementById(BiayaPilihCallSignClientID).value.replace(/, /, "");
    var BiayaUangPangkal = document.getElementById(BiayaUangPangkalClientID).value.replace(/, /, "");

    var PNBP = 0;
    var Adm = 0;
    var Iuran = 0;
    var PilihCallSign = 0;
    var UangPangkal = 0;
    var TotalBiaya = 0;
    
    BiayaPNBP = BiayaPNBP == "" ? "0" : BiayaPNBP;
    BiayaAdm = BiayaAdm == "" ? "0" : BiayaAdm;
    BiayaIuran = BiayaIuran == "" ? "0" : BiayaIuran;
    BiayaPilihCallSign = BiayaPilihCallSign == "" ? "0" : BiayaPilihCallSign;
    BiayaUangPangkal = BiayaUangPangkal == "" ? "0" : BiayaUangPangkal;

    PNBP = parseInt(BiayaPNBP);
    Adm = parseInt(BiayaAdm);
    Iuran = parseInt(BiayaIuran);
    PilihCallSign = parseInt(BiayaPilihCallSign);
    UangPangkal = parseInt(BiayaUangPangkal);
    
    TotalBiaya = PNBP + Adm + Iuran + PilihCallSign + UangPangkal

    document.getElementById(TotalBiayaClientID).value = TotalBiaya
    return;
}
function BeginCallback(s, e) {
    loadingPanel.Show();
}

function EndCallback(s, e) {
    loadingPanel.Hide();
} 