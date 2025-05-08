'use client';

import { deleteInvoice } from "@/app/lib/actions";
import { TrashIcon } from "@heroicons/react/24/outline";
import { useState } from "react";

export default function ConfirmDelete({ id }: { id: string }) {
  const [isModalOpen, setIsModalOpen] = useState(false);
  const deleteInvoiceWithId = deleteInvoice.bind(null, id);

  return (
    <form action={async () => {
        setIsModalOpen(false);
        await deleteInvoiceWithId();
      }}>
      <button
        type='button'
        onClick={() => setIsModalOpen(true)}
        className="rounded-md border p-2 hover:bg-gray-100">
        <span className="sr-only">Delete</span>
        <TrashIcon className="w-5" />
      </button>
      {isModalOpen && (
        <div className="fixed inset-0 flex items-center justify-center bg-black bg-opacity-50">
          <div className="bg-white p-4 rounded-md">
            <p>Are you sure you want to delete this invoice?</p>
            <div className="mt-4 flex justify-end space-x-2">
              <button
                type='button'
                onClick={() => setIsModalOpen(false)}
                className="px-4 py-2 bg-gray-300 rounded-md"
              >
                Cancel
              </button>

                <button
                  type="submit"
                  className="px-4 py-2 bg-red-600 text-white rounded-md"
                >
                  Delete
                </button>
            </div>
          </div>
        </div>
      )}
    </form>
  );
}
