﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Record
{
    interface IDatabase
    {
          string userTableSelect(string tempdata);
          string getUserId();
          string getPassword();
          string getUsername();
          int getNoofdocument(string user);
          string getDepartment();
          string getEmail();
          string getUsertype();
          string showImage();
          int userCount();
          string userAndDocumentTableSelect(string tempuser);
          string userAndDocumentTableSelectAndReturnDocName(string tempuser);
          string userAndDocumentTableSelectByListBoxIndex(string tempuser, int index);
          string docRight(string userId, string docId);
          int userAndDocumentCount();
          string documentTableSelect(string docId);
          string documentTableSelectByDocName(string docName, string user);
          string documentTableSelectByDocNameForGroupDoc(string docName, string gId);
          void setDocument(string docId);
          string getDocType(string docId);
          string getFilingPath(string docId);
          string getFilingPath();
          string getFilingPathByDocId(string docId);
          string getDocName();
          string getDocName(string docId);
          int getTotalShareInGroup(string docId);
          int getTotalShareIndividual(string docId);
          string getDocCheckInTime(string docId);
          string getDocCheckOutTime(string docId);
          string getDocSize(string docId);
          int DocumentCount();
          DocumentTable getDocument(string docId);
          void documentTableInsert(string docName, string docId, string docType, string scanId, string filingPath, string fileId, string checkInTime, string docSize);
          void checkOutTimeInsert(string checkOutTime);
          void userAndDocumentTableInsert(string userId, string docId, string docRight);
          void udateNoOfDocument(string userId);
          void udateNoOfDocumentAfterDeletingAfile(string userId);
          void udateNoOfGroupIncrease(string tempuser);
          void udateNoOfGroupDecrease(string tempuser);
          void selectDocumentTableForUpdate(string docId);
          void documentTableUpdate(string docName, string docType, string filingPath);
          void totalShareIndividualUpdate(string docId);
          void totalShareInGroupUpdate(string docId);
          void checkOutTimeUpdate(string checkOutTime);
          void deleteFromUserAndDocumentTable(string userId, string docId);
          string deleteFromUserAndDocumentTableByDocId(string docId);
          void deleteFromDocumentTable(string docId);
          void deleteFromDocumentAndGroupTableAndNoOfDocDecreaseInGroupTable(string docId, string gId);
          void deleteFromDocumentAndGroupTableByDocId(string docId);
          void groupTableInsert(string groupId, string groupName, string adminId);
          int groupTableCount();
          void GroupTableSelect(string gId);
          string GroupTableSelectByGroupIdAndReturnAdminId(string gId);
          string UserAndGroupTableSelectAndReturnGroupNames(string tempuser);
          string GroupTableSelectForGroupId(string gName, string user);
          string getGroupName(string gId);
          string getAdminId(string gId);
          int getTotalMember(string gId);
          int getTotalDocument(string gId);
          void updateTotalDocument(string gId);
          void updateAdminId(string adminId, string gId);
          void updateTotalMemberIncrease(string gId);
          void updateTotalMemberDecrease(string gId);
          int userAndGroupTableCount();
          int documentAndGroupTableCount();
          void userAndGroupTableInsert(string gAdmin, string gId);
          string userAndGroupTableSelect(string tempuser);
          void deleteFromuserAndGroupTable(string memberId, string groupId);
          void deleteFromuserAndGroupTable(string groupId);
          void deleteFromdocumentAndGroupTable(string groupId);
          Boolean userAndGroupTableCheckByGidAndUId(string adminId, string gId);
          string documentAndGroupTableSelect(string gId);
          string documentAndGroupTableSelectAndReturnDocName(string gId);
          string userAndGroupTableSelectByGroupId(string gId);
          int getNoOfGroup(string userId);
          void documentAndGroupTableInsert(string dId, string gId, string docRight);
          string firstRowGroupTable();
          string firstRowDocumentTable();
          int firstRowUserAndGroupTable();
          int firstRowUserAndDocumentTable();
          int firstRowDocumentAndGroupTable();
          string lastRowGroupTable();
          string lastRowDocumentTable();
          int LastRowUserAndGroupTable();
          int LastRowUserAndDocumentTable();
          int LastRowDocumentAndGroupTable();
    }
}