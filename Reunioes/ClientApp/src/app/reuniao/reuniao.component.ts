import { Component, OnInit, Input } from '@angular/core';
import { Reuniao } from '../model/reuniao';
import { Sala } from '../model/sala';
import { SalaService } from '../services/sala.service';
import { ReuniaoService } from '../services/reuniao.service';

@Component({
  selector: 'app-reuniao',
  templateUrl: './reuniao.component.html',
  styleUrls: ['./reuniao.component.css']
})
export class ReuniaoComponent implements OnInit {

  @Input() value;
  reuniao: Reuniao;
  reuniaoCadastrada: boolean = false;
  salas : Sala[];

  public mensagem: string;
  public ativarSpinner: boolean;

  constructor(private salaServico: SalaService, 
          private reuniaoServico: ReuniaoService ) { 
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
  }

  public criarReuniao(){
    this.mensagem = "";
    this.ativarSpinner = true;
    this.reuniaoServico.cadastrar(this.reuniao).subscribe(
      reuniaoJson => {
        this.reuniaoCadastrada = true;
        this.ativarSpinner = false;
      },
      e => {
        this.mensagem = e.error;
        this.ativarSpinner = false;
      }
    );
  }

}
