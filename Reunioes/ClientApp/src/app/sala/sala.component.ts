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

  public salas: Sala[];

  public mensagem: string;
  public salaCadastrada: boolean = false;
  public ativarSpinner: boolean;

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
    this.sala = new Sala;
  }

  public cadastrar(){
    this.mensagem = "";
    this.ativarSpinner = true;
    this.salaServico.cadastrar(this.sala)
      .subscribe(
        salaJson => {
          this.salaCadastrada = true;
          this.mensagem = "";
          this.ativarSpinner = false;
          this.salaServico.obterTodos().subscribe(
            salas => {
              this.salas = salas;
            },
            e => {
              console.log(e.error);
            }
          );
        },
        e => {
          this.mensagem = e.error;
          this.ativarSpinner = false;
        }
      );
  }
  
  public deletarSala(sala: Sala){
    var retorno = confirm("Deseja realmente excluir a sala?");
    if (retorno == true) {
      this.salaServico.deletar(sala).subscribe(
        salas => {
          this.salas = salas;
        },
        e => {
          console.log(e.error);
        }
      );
    }
  }
}
