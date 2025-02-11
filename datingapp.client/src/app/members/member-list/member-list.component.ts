import { Component, inject, OnInit } from '@angular/core';
import { MembersService } from '../../_services/members.service';
import { IMember } from '../../_models/IMember';
import { MemberCardComponent } from "../member-card/member-card.component";

@Component({
  selector: 'app-member-list',
  imports: [MemberCardComponent],
  templateUrl: './member-list.component.html',
  styleUrl: './member-list.component.css'
})
export class MemberListComponent implements OnInit {
  memberService = inject(MembersService);

  ngOnInit() {
    if (this.memberService.members().length === 0)
      this.loadMembers();
  }

  loadMembers() {
    this.memberService.getMembers();
  }
}
