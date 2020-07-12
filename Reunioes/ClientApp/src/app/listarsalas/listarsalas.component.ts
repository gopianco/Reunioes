import { Component, OnInit } from '@angular/core';
import { Sala } from '../model/sala';
import { SalaService } from '../services/sala.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-listarsalas',
  templateUrl: './listarsalas.component.html',
  styleUrls: ['./listarsalas.component.css']
})
export class ListarsalasComponent implements OnInit {


  public salas: Sala[];
  
  constructor(private salaService: SalaService) { 
    this.salaService.obterTodos().subscribe(
      salas => {
        this.salas = salas;
      },
      e => {
        console.log(e.error);
      }
    );

  }

  ngOnInit() {
  }


}
