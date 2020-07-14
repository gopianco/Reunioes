import { SalaService } from './../services/sala.service';
import { ReuniaoService } from './../services/reuniao.service';
import { Component, OnInit } from '@angular/core';
import { Reuniao } from '../model/reuniao';
import { Sala } from '../model/sala';

@Component({
  selector: 'app-listar-reunioes',
  templateUrl: './listar-reunioes.component.html',
  styleUrls: ['./listar-reunioes.component.css']
})
export class ListarReunioesComponent implements OnInit {


  public salasComReuniao : Sala[];
  public reunioesDiponiveis : Sala[];
  public reunioes: {};

  constructor(private salaServico: SalaService) {
    
    this.salaServico.obterAgendados().subscribe(
      agendados =>{
        this.salasComReuniao = agendados;
        console.log(this.salasComReuniao)
        
      },
      e => {
        console.log(e.error);
      });

   }
   
   ngOnInit() {
   
  }

}
