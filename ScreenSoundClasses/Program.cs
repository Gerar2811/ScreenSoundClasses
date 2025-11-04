Banda linkinPark = new Banda("Linkin Park");

Album albumDoLinkin = new Album("Hybrid Theory");

Musica musica1 = new Musica(linkinPark, "Crawling")
{
    Duracao = 250,
    Disponivel = false,
};


Musica musica2 = new Musica(linkinPark, "Papercut")
{
    Duracao = 200,
    Disponivel = true,
};

albumDoLinkin.AdicionarMusica(musica1);
albumDoLinkin.AdicionarMusica(musica2);

musica1.FichaTecnicaMusica();
musica2.FichaTecnicaMusica();
linkinPark.AdicionarAlbum(albumDoLinkin);
linkinPark.MostrarDiscografia();


