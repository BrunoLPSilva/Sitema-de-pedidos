import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-status-selector',
  templateUrl: './status-selector.component.html',
  styleUrls: ['./status-selector.component.scss']
})
export class StatusSelectorComponent {
  @Input() status: string = 'Pendente';
  @Output() statusSelecionado = new EventEmitter<string>();
}
