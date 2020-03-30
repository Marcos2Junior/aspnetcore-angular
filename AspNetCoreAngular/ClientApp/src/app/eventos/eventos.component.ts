import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
/** eventos component*/
export class EventosComponent implements OnInit {

  eventos: any;

  /** eventos ctor */
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getEventos();
  }

  getEventos() {
    this.http.get('https://localhost:44342/api/Eventoes').subscribe(response => {
      this.eventos = response;
      console.log(response);
    }, error => {
        console.log(error);
    });
  }
}
