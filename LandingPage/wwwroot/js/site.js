function downloadCV() {
    let url = '/imagenes/cv_es.pdf';
    let name = 'Emmanuel-Zelarayan-CV-Programador-NET.pdf';
    const link = document.createElement('a');
    link.href = url;
    link.target = '_blank';
    link.download = name;
    link.click();
}
