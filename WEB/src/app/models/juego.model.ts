export class Juego {
  id: number;
  nombre: string | null;
  descripcion: string | null;
  fecha_lanzamiento: Date | null;
  genero: string | null;
  plataforma: string | null;
  imagen: string | null;

  constructor() {
    this.id = 0;
    this.nombre = null;
    this.descripcion = null;
    this.fecha_lanzamiento = null;
    this.genero = null;
    this.plataforma = null;
    this.imagen= null;
  }
}
