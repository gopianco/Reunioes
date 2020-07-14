import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { SalaComponent } from './sala/sala.component';
import { SalaService } from './services/sala.service';
import { ReuniaoService } from './services/reuniao.service';
import { ReuniaoComponent } from './reuniao/reuniao.component';
import { ListarReunioesComponent } from './listar-reunioes/listar-reunioes.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
  
    SalaComponent,
    ReuniaoComponent,
    ListarReunioesComponent,
    
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
     
      { path: 'sala', component: SalaComponent },
      { path: 'reuniao', component: ReuniaoComponent },
      { path: 'listar-reunioes', component: ListarReunioesComponent },
      
    ])
  ],
  providers: [SalaService, ReuniaoService],
  bootstrap: [AppComponent]
})
export class AppModule { }
