import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CriarPedidoComponent } from './pages/criar-pedido/criar-pedido.component';
import { AtualizarStatusComponent } from './pages/atualizar-status/atualizar-status.component';
import { PedidoFormComponent } from './components/pedido-form/pedido-form.component';
import { PedidoListComponent } from './components/pedido-list/pedido-list.component';
import { StatusSelectorComponent } from './components/status-selector/status-selector.component';
import { FormsModule } from '@angular/forms';
import { ListarPedidosComponent } from './pages/listar-pedidos/listar-pedidos.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    CriarPedidoComponent,
    AtualizarStatusComponent,
    PedidoFormComponent,
    PedidoListComponent,
    StatusSelectorComponent,
    ListarPedidosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
