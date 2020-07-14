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
  public salas : Sala[];
  public mensagem: string;
  public mensagemErro: string;
  public ativarSpinner: boolean;
  
  reuniao: Reuniao;

  constructor(private salaServico: SalaService,
        private reuniaoServico: ReuniaoService) {
    
    this.salaServico.obterAgendados().subscribe(
      agendados =>{
        this.salasComReuniao = agendados;
      },
      e => {
        console.log(e.error);
      });

      this.salaServico.obterTodos().subscribe(
        salas => {
          this.salas = (salas);
        },
        e => {
          console.log(e.error);
        }
      );

      
  }
  
  
  ngOnInit() {
    this.reuniao = new Reuniao;
    this.reuniao.titulo = "teste";
  }
  
  consultarReuniao(){
    this.mensagem = "";
    this.mensagemErro = "";
    this.ativarSpinner = true;
    this.reuniaoServico.consultarAgenda(this.reuniao).subscribe(
      r =>{
        this.mensagem = "A sala está disponivel para esta data";
        this.ativarSpinner = false;
      },
      e => {
        this.ativarSpinner = false;
        this.mensagemErro = e.error;
        
      }
      )
  }

}
