import { Component, OnInit } from '@angular/core';
import { SalaService } from '../services/sala.service';
import { Sala } from '../model/sala';

@Component({
  selector: 'app-sala',
  templateUrl: './sala.component.html',
  styleUrls: ['./sala.component.css']
})
export class SalaComponent implements OnInit {
  sala: Sala;

  public mensagem: string;
  public salaCadastrada: boolean;

  constructor(private salaServico: SalaService) { }

  ngOnInit() {
    this.sala = new Sala;
  }

  public cadastrar(){
    this.salaServico.cadastrar(this.sala)
      .subscribe(
        salaJson => {
          this.salaCadastrada = true;
          this.mensagem = "";
        },
        e => {
          this.mensagem = e.error;
        }
      );
  }

}
