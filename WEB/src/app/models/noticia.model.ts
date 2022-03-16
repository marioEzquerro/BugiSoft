export class Noticia {
  Id: number;
  nombre: string | null;
  descripcion_corta: string | null;
  descripcion: string | null;
  img: string | null;
  fecha: Date | null;

  constructor() {
    this.Id = 0;
    this.nombre = null;
    this.descripcion_corta = null;
    this.descripcion = null;
    this.img = null;
    this.fecha = null;
  }
}

