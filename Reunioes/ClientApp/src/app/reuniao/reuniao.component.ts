import { Component, OnInit } from '@angular/core';
import { Reuniao } from '../model/reuniao';
import { Sala } from '../model/sala';
import { SalaService } from '../services/sala.service';

@Component({
  selector: 'app-reuniao',
  templateUrl: './reuniao.component.html',
  styleUrls: ['./reuniao.component.css']
})
export class ReuniaoComponent implements OnInit {

  reuniao: Reuniao;
  salas : Sala[];

  constructor(private salaServico: SalaService) { 
    this.salaServico.obterTodos().subscribe(
      salas => {
        this.salas = salas;
      },
      e => {
        console.log(e.error);
      }
    );
  }


  ngOnInit() {
    this.reuniao = new Reuniao;
  }

}
