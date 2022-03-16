export class Noticia {
  id: number;

  nombre: string | null;

  descripcion_corta: string | null;

  descripcion: string | null;

  img: string | null;

  fecha: Date | null;

  constructor() {
    this.id = 0;
    this.nombre = null;
    this.descripcion_corta = null;
    this.descripcion = null;
    this.img = null;
    this.fecha = null;
  }
}
