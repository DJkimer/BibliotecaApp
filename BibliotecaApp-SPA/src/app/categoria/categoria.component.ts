import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-categoria',
  templateUrl: './categoria.component.html',
  styleUrls: ['./categoria.component.css']
})
export class CategoriaComponent implements OnInit {
  categorias: any;
  constructor(private http: HttpClient) { }
  ngOnInit() {
    this.getCategorias();
  }

  getCategorias() {
    this.http.get('http://localhost:5000/api/categorias').subscribe(response => {
      this.categorias = response;
    }, error => {
      console.log(error);
    });
  }
}
